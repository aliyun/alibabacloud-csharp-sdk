// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class DeleteDataMaskingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The database engine type. This value must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The database instance identity. You can obtain this value from the Items[].InstanceId field in the response of the ListDataMaskingInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The cloud service code. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also provided, the two parameters must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud service type identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.
        /// If specified together with ProductCode, the values must correspond to each other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The list of column encryption targets grouped by database and table.</para>
        /// </summary>
        [NameInMap("SubRuleList")]
        [Validation(Required=false)]
        public List<DeleteDataMaskingRuleRequestSubRuleList> SubRuleList { get; set; }
        public class DeleteDataMaskingRuleRequestSubRuleList : TeaModel {
            /// <summary>
            /// <para>The list of target column names. Separate multiple column names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone,email</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public string Columns { get; set; }

            /// <summary>
            /// <para>The name of the target database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The name of the target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

    }

}
