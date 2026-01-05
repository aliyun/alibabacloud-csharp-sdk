// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateTagOptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the tag option.</para>
        /// </summary>
        [NameInMap("TagOptionDetail")]
        [Validation(Required=false)]
        public UpdateTagOptionResponseBodyTagOptionDetail TagOptionDetail { get; set; }
        public class UpdateTagOptionResponseBodyTagOptionDetail : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tag option is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default)</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The key of the tag option.</para>
            /// <para>The key must be 1 to 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c> and cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the tag option belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>133413081827****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-bp1u6mdf3d****</para>
            /// </summary>
            [NameInMap("TagOptionId")]
            [Validation(Required=false)]
            public string TagOptionId { get; set; }

            /// <summary>
            /// <para>The value of the tag option.</para>
            /// <para>The value must be 1 to 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c> and cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
