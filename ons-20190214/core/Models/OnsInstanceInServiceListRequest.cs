// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether you want the resource information to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedResourceInfo")]
        [Validation(Required=false)]
        public bool? NeedResourceInfo { get; set; }

        /// <summary>
        /// <para>The tags that you want to attach to the instance. You can attach up to 20 tags to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsInstanceInServiceListRequestTag> Tag { get; set; }
        public class OnsInstanceInServiceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter is not required. If you configure this parameter, you must also configure <b>Value</b>.**** If you configure Key and Value in a request, this operation queries only the instances that use the specified tags. If you do not configure these parameters in a request, this operation queries all instances that you can access.</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter cannot be an empty string.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CartService</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter is not required. If you configure this parameter, you must also configure <b>Key</b>.**** If you configure Key and Value in a request, this operation queries only the instances that use the specified tags. If you do not configure these parameters in a request, this operation queries all instances that you can access.</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter can be an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SericeA</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
