// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the dataset data in JSON format: `{ "cube": { "dimensions": [ { "caption": "customer name", "dataType": "string", "dimensionType": "standard_dimension", "factColumn": "customer_name", "uid": "N5820f5_customer_name" }, { "caption": "datastring", "" standard_dimension", "factColumn": "order_id", "uid": "N5820f5_order_id" }, ], "measures": [ { "caption": "order amount ", "dataType": "number", "factColumn": "order_amt", "measureType": "standard_measure ": " Nderamid " }, " { "customsql": false, "dsId": "261b252d-c3c3-498a-a0a7-5d1ec6cd****", "tableName": "company_sales_record_copy" } }, "datasetId": "5820f58c-c734-4d8a-baf1-7979af4f****", "datasetName": "company_sales_record_copy12", "datasource": { "dsId": "261b252d-c3c3-498a-a0a7-5d1ec6cd****", "dsName": "Self-use", "dsType": "mysql" }, "directory" { "id": "schemaad8aad00-9c55-4984-a767-b4e0ec60****", "name": "My dataset", "pathId": "schemaad8aad00-9c55-4984-a767-b4e0ec60****", "pathName": "My dataset" }, "ownerId": "13651626232****", "ownerName": "Zhang San", "rowLevel": false, "workspaceId": "95296e95-ca89-4c7d-8af9-dedf0ad0****", "workspaceName": "Test Workspace" }`
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// The execution result of the interface is returned. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
