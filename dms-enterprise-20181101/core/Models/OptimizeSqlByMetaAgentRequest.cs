// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class OptimizeSqlByMetaAgentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1***</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// <para>The name of the selected model. You can use only Qwen series models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>是否为慢SQL</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The SQL statement that you want to analyze.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from table where col = 1</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
