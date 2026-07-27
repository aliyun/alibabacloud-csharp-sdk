// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The collection of data masking rules to add or update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public List<DsgDesensPlanAddOrUpdateRequestDesensRules> DesensRules { get; set; }
        public class DsgDesensPlanAddOrUpdateRequestDesensRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to add a watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Adds a watermark.</para>
            /// </description></item>
            /// <item><description><para>false: Does not add a watermark.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckWatermark")]
            [Validation(Required=false)]
            public bool? CheckWatermark { get; set; }

            /// <summary>
            /// <para>The sensitive data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The configuration of the data masking method.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DesensPlan")]
            [Validation(Required=false)]
            public DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan DesensPlan { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan : TeaModel {
                /// <summary>
                /// <para>The data masking method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>hash: hashing</para>
                /// </description></item>
                /// <item><description><para>mapping: pseudonymization</para>
                /// </description></item>
                /// <item><description><para>mask: masking</para>
                /// </description></item>
                /// <item><description><para>charreplacement: character replacement</para>
                /// </description></item>
                /// <item><description><para>intervalselect: interval transformation</para>
                /// </description></item>
                /// <item><description><para>decimalpoint: rounding</para>
                /// </description></item>
                /// <item><description><para>emptydesens: nullification</para>
                /// </description></item>
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
                /// <para>The parameters for the data masking method.</para>
                /// </summary>
                [NameInMap("ExtParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtParam { get; set; }

            }

            /// <summary>
            /// <para>The data masking rule ID. You can call the <a href="https://help.aliyun.com/document_detail/2786578.html">DsgDesensPlanQueryList</a> operation to obtain it.</para>
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
            /// <para>The secondary data masking scenes.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SceneIds")]
            [Validation(Required=false)]
            public List<long?> SceneIds { get; set; }

            /// <summary>
            /// <para>The status of the data masking rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Disabled</para>
            /// </description></item>
            /// <item><description><para>1: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The associated columns for masking.</para>
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
                /// <para>The name of the DataWorks workspace.</para>
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

            [NameInMap("emptyNotDesens")]
            [Validation(Required=false)]
            public bool? EmptyNotDesens { get; set; }

        }

    }

}
