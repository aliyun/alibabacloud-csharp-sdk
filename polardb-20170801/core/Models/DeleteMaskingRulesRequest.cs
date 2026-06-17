// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteMaskingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The type of rule to delete. Valid values:</para>
        /// <para>v1: deletes data masking rules.
        /// v2: deletes data encryption rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("InterfaceVersion")]
        [Validation(Required=false)]
        public string InterfaceVersion { get; set; }

        /// <summary>
        /// <para>The names of the data masking rules to delete. To delete multiple rules in a batch, separate the names with commas (,).</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/212573.html">DescribeMaskingRules</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public string RuleNameList { get; set; }

    }

}
