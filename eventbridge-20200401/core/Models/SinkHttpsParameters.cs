// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkHttpsParameters : TeaModel {
        /// <summary>
        /// <para>HTTP Body</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public SinkHttpsParametersBody Body { get; set; }
        public class SinkHttpsParametersBody : TeaModel {
            /// <summary>
            /// <para>Form</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEMPLATE</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>Template</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;message&quot;:&quot;${message}&quot;}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>Value</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;message&quot;:&quot;$.data.message&quot;}</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The HTTP method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The network type, PrivateNetwork/PublicNetwork.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublicNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>HTTP Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The HTTP/HTTPS address.</para>
        /// </summary>
        [NameInMap("URL")]
        [Validation(Required=false)]
        public SinkHttpsParametersURL URL { get; set; }
        public class SinkHttpsParametersURL : TeaModel {
            /// <summary>
            /// <para>Form</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>Template</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://${host}/events</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>Value</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/events">https://example.com/events</a></para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>vpc ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
