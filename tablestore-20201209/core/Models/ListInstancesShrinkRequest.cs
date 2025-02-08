// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The names of the instances. This parameter is used to specify multiple instances that you want to query at the same time.</para>
        /// </summary>
        [NameInMap("InstanceNameList")]
        [Validation(Required=false)]
        public string InstanceNameListShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of instances that you want to return. Valid values: 0 to 200. If you do not configure this parameter or set this parameter to 0, the default value of 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start position of the query. Set this parameter to the value of the NextToken parameter that is returned from the last call. Instances are returned in lexicographical order starting from the position that is specified by this parameter. The first time you call the operation, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESCG15aC1xxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can query the ID on the Resource Group page in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek24upgom6p5ri</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
