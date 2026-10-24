// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeAssetScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint asset scope details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAssetScopeResponseBodyData Data { get; set; }
        public class DescribeAssetScopeResponseBodyData : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792800000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792803600000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the asset scope record, which corresponds to the Id request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1932</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The effective scope mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: all user groups.</description></item>
            /// <item><description><b>UserGroupNormal</b>: specified user groups.</description></item>
            /// <item><description><b>DeviceGroupNormal</b>: specified device groups.</description></item>
            /// <item><description><b>DevTagNormal</b>: specified device tags.</description></item>
            /// </list>
            /// <para>The meaning of MatchTargetIds is determined by this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The list of effective scope targets. All elements are strings. The meaning of each element is determined by MatchMode:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: Scope matching does not depend on this list.</description></item>
            /// <item><description><b>UserGroupNormal</b>: the user group ID.</description></item>
            /// <item><description><b>DeviceGroupNormal</b>: the device group ID.</description></item>
            /// <item><description><b>DevTagNormal</b>: the device tag value.</description></item>
            /// </list>
            /// <para>This list is not a list of matched endpoint UUIDs.</para>
            /// </summary>
            [NameInMap("MatchTargetIds")]
            [Validation(Required=false)]
            public List<string> MatchTargetIds { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A157FA-F957-3A5A-A6B8-5BBB8ADB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
