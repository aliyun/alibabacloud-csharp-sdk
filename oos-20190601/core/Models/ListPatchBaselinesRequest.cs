// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListPatchBaselinesRequest : TeaModel {
        /// <summary>
        /// <para>The approved patches.</para>
        /// </summary>
        [NameInMap("ApprovedPatches")]
        [Validation(Required=false)]
        public List<string> ApprovedPatches { get; set; }

        /// <summary>
        /// <para>Specifies whether the approved patch involves updates other than security-related updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApprovedPatchesEnableNonSecurity")]
        [Validation(Required=false)]
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the patch baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyPatchBaseline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows</description></item>
        /// <item><description>Ubuntu</description></item>
        /// <item><description>CentOS</description></item>
        /// <item><description>Debian</description></item>
        /// <item><description>AliyunLinux</description></item>
        /// <item><description>RedhatEnterpriseLinux</description></item>
        /// <item><description>Anolis</description></item>
        /// <item><description>AlmaLinux</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunLinux</para>
        /// </summary>
        [NameInMap("OperationSystem")]
        [Validation(Required=false)]
        public string OperationSystem { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The share type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>Private</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The patch source configurations.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPatchBaselinesRequestTags> Tags { get; set; }
        public class ListPatchBaselinesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
