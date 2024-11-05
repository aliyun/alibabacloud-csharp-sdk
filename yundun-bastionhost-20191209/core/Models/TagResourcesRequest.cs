// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the bastion hosts to which you want to create and add tags.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>An array that consists of IDs of bastion hosts.</para>
        /// <para>Valid values: 1 to 20.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query IDs of bastion hosts.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Set the value to <b>INSTANCE</b>, which indicates that the resource is a bastion host.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the bastion host. You can specify up to 20 tags for the bastion host.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Thekey cannot be an empty string. The key can be up to 128 characters in length. </description></item>
            /// <item><description>It cannot start with <b>aliyun</b> or <b>acs:</b>, and cannot contain <b>http://</b> or <b>https://</b>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>operation</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the bastion host.\
            /// You can specify up to 20 tags for the bastion host.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value can be a string of up to 128 characters or an empty string.</description></item>
            /// <item><description>It cannot start with <b>aliyun</b> or <b>acs:</b>, and cannot contain <b>http://</b> or <b>https://</b>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>operation_test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
