// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRecordRequest : TeaModel {
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public CreateRecordRequestAuthConf AuthConf { get; set; }
        public class CreateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v4</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>业务场景</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;value&quot;:&quot;2.2.2.2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateRecordRequestData Data { get; set; }
        public class CreateRecordRequestData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dGVzdGFkYWxrcw==</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abcdef1234567890</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        /// <summary>
        /// <para>是否代理加速</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>记录名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>记录类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A/AAAA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
