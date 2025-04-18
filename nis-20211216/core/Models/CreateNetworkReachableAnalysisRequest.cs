// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateNetworkReachableAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network path. You can call the <a href="https://help.aliyun.com/document_detail/2366522.html">CreateNetworkPath</a> operation to obtain the ID of the network path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-b2f618ceb2c84057****</para>
        /// </summary>
        [NameInMap("NetworkPathId")]
        [Validation(Required=false)]
        public string NetworkPathId { get; set; }

        /// <summary>
        /// <para>The ID of the region for which you want to create a task for analyzing network reachability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkReachableAnalysisRequestTag> Tag { get; set; }
        public class CreateNetworkReachableAnalysisRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag to add to the resource. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>You can add up to 20 tags in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag to add to the resource. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value can be an empty string.</para>
            /// <para>You can add up to 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
