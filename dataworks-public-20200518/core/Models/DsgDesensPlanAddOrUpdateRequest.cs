// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>A collection of data masking rules that you want to add or modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public List<DsgDesensPlanAddOrUpdateRequestDesensRules> DesensRules { get; set; }
        public class DsgDesensPlanAddOrUpdateRequestDesensRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to add a watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckWatermark")]
            [Validation(Required=false)]
            public bool? CheckWatermark { get; set; }

            /// <summary>
            /// <para>The sensitive field type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The data masking rule.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DesensPlan")]
            [Validation(Required=false)]
            public DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan DesensPlan { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan : TeaModel {
                /// <summary>
                /// <para>The masking method configured in the data masking rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hash</description></item>
                /// <item><description>mapping</description></item>
                /// <item><description>mask</description></item>
                /// <item><description>charreplacement</description></item>
                /// <item><description>intervalselect</description></item>
                /// <item><description>decimalpoint</description></item>
                /// <item><description>emptydesens</description></item>
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
                /// <para>The parameters for the data masking rule.</para>
                /// </summary>
                [NameInMap("ExtParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtParam { get; set; }

            }

            /// <summary>
            /// <para>The ID of the data masking rule. You can call the <a href="https://help.aliyun.com/document_detail/2786578.html">DsgDesensPlanQueryList</a> operation to query the ID of the data masking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

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
            /// <para>The level-2 data masking scenario.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SceneIds")]
            [Validation(Required=false)]
            public List<int?> SceneIds { get; set; }

            /// <summary>
            /// <para>The status of the data masking rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: expired</description></item>
            /// <item><description>1: effective</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
