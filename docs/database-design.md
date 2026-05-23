# Database Design

## Relationships

- One Supplier can have many Products.
- One Category can have many Products.
- One Product can have many StockMovements.
- One User can create many StockMovements.
- One User can create many AuditLogs.

## Products Table

The Products table stores information about items that are tracked in the inventory system.

### Columns

| Column | Data Type | Description |
|---|---|---|
| Id | int | Primary key. Unique identifier for each product. |
| Name | string | Product name. |
| Sku | string | Unique stock keeping unit used to identify the product. |
| Description | string | Optional product description. |
| Quantity | int | Current quantity in stock. |
| Price | decimal | Product price or value. |
| SupplierId | int | Foreign key connected to the Suppliers table. |
| CategoryId | int | Foreign key connected to the Categories table. |
| CreatedAt | DateTime | Date and time when the product was created. |
| UpdatedAt | DateTime | Date and time when the product was last updated. |


## Suppliers Table

The Suppliers table stores information about companies or vendors that provide products.

### Columns

| Column | Data Type | Description |
|---|---|---|
| Id | int | Primary key. Unique identifier for each supplier. |
| Name | string | Supplier or vendor name. |
| ContactName | string | Name of the supplier contact person. |
| Email | string | Supplier email address. |
| Phone | string | Supplier phone number. |
| Address | string | Supplier address. |
| CreatedAt | DateTime | Date and time when the supplier was created. |





