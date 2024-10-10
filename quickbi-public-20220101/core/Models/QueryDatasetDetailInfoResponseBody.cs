// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E1E63-B337-44F8-8C22-6F00DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the dataset data in JSON format: <c>{ &quot;cube&quot;: { &quot;dimensions&quot;: [ { &quot;caption&quot;: &quot;customer name&quot;, &quot;dataType&quot;: &quot;string&quot;, &quot;dimensionType&quot;: &quot;standard_dimension&quot;, &quot;factColumn&quot;: &quot;customer_name&quot;, &quot;uid&quot;: &quot;N5820f5_customer_name&quot; }, { &quot;caption&quot;: &quot;datastring&quot;, &quot;&quot; standard_dimension&quot;, &quot;factColumn&quot;: &quot;order_id&quot;, &quot;uid&quot;: &quot;N5820f5_order_id&quot; }, ], &quot;measures&quot;: [ { &quot;caption&quot;: &quot;order amount &quot;, &quot;dataType&quot;: &quot;number&quot;, &quot;factColumn&quot;: &quot;order_amt&quot;, &quot;measureType&quot;: &quot;standard_measure &quot;: &quot; Nderamid &quot; }, &quot; { &quot;customsql&quot;: false, &quot;dsId&quot;: &quot;261b252d-c3c3-498a-a0a7-5d1ec6cd****&quot;, &quot;tableName&quot;: &quot;company_sales_record_copy&quot; } }, &quot;datasetId&quot;: &quot;5820f58c-c734-4d8a-baf1-7979af4f****&quot;, &quot;datasetName&quot;: &quot;company_sales_record_copy12&quot;, &quot;datasource&quot;: { &quot;dsId&quot;: &quot;261b252d-c3c3-498a-a0a7-5d1ec6cd****&quot;, &quot;dsName&quot;: &quot;Self-use&quot;, &quot;dsType&quot;: &quot;mysql&quot; }, &quot;directory&quot; { &quot;id&quot;: &quot;schemaad8aad00-9c55-4984-a767-b4e0ec60****&quot;, &quot;name&quot;: &quot;My dataset&quot;, &quot;pathId&quot;: &quot;schemaad8aad00-9c55-4984-a767-b4e0ec60****&quot;, &quot;pathName&quot;: &quot;My dataset&quot; }, &quot;ownerId&quot;: &quot;13651626232****&quot;, &quot;ownerName&quot;: &quot;Zhang San&quot;, &quot;rowLevel&quot;: false, &quot;workspaceId&quot;: &quot;95296e95-ca89-4c7d-8af9-dedf0ad0****&quot;, &quot;workspaceName&quot;: &quot;Test Workspace&quot; }</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>A JSON dataset is returned. For more information, see the description on the left.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The execution result of the interface is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
