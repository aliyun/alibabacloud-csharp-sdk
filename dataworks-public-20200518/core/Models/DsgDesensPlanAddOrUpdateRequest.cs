// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The collection of data masking rules to create or update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public List<DsgDesensPlanAddOrUpdateRequestDesensRules> DesensRules { get; set; }
        public class DsgDesensPlanAddOrUpdateRequestDesensRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to add a watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckWatermark")]
            [Validation(Required=false)]
            public bool? CheckWatermark { get; set; }

            /// <summary>
            /// <para>The sensitive field type. The value is obtained from the sensitive data type templates available to the current tenant. You can call the DsgQueryDefaultTemplates operation to query the templates and their supported data masking rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The data masking plan.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DesensPlan")]
            [Validation(Required=false)]
            public DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan DesensPlan { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan : TeaModel {
                /// <summary>
                /// <para>The data masking method configured in the data masking plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hash: Hashing.</description></item>
                /// <item><description>mapping: Pseudonymization.</description></item>
                /// <item><description>mask: Masking.</description></item>
                /// <item><description>charreplacement: Character replacement.</description></item>
                /// <item><description>intervalselect: Interval transformation.</description></item>
                /// <item><description>decimalpoint: Rounding.</description></item>
                /// <item><description>emptydesens: Nullification.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hash</para>
                /// </summary>
                [NameInMap("DesensPlanType")]
                [Validation(Required=false)]
                public string DesensPlanType { get; set; }

                /// <summary>
                /// <para>The parameters of the data masking plan.</para>
                /// </summary>
                [NameInMap("ExtParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtParam { get; set; }

            }

            /// <summary>
            /// <para>The ID of the data masking rule. You can call the <a href="https://help.aliyun.com/document_detail/2786578.html">DsgDesensPlanQueryList</a> operation to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The owner of the data masking rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the data masking rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone_hash</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The level-2 data masking scenarios.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SceneIds")]
            [Validation(Required=false)]
            public List<long?> SceneIds { get; set; }

            /// <summary>
            /// <para>The effective status of the data masking rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Inactive.</description></item>
            /// <item><description>1: Active.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The list of columns associated with the data masking rule.</para>
            /// </summary>
            [NameInMap("columns")]
            [Validation(Required=false)]
            public List<DsgDesensPlanAddOrUpdateRequestDesensRulesColumns> Columns { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesColumns : TeaModel {
                /// <summary>
                /// <para>The column name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_col_dev</para>
                /// </summary>
                [NameInMap("column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The data source type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS.ODPS</para>
                /// </summary>
                [NameInMap("dbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_dev</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table_dev</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to keep null values unmasked. A value of true indicates that null values are not masked. A value of false indicates that null values are processed based on the rule.</para>
            /// </summary>
            [NameInMap("emptyNotDesens")]
            [Validation(Required=false)]
            public bool? EmptyNotDesens { get; set; }

        }

    }

}
