// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AccessPageGetAclResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AccessPageGetAclResponseBodyData> Data { get; set; }
        public class AccessPageGetAclResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FREE_ACCESS</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://wuying.aliyun.com/native-solution/cloud-flow/view?id=a-075nu7bcqim2wvxli&token=8141B1A674D48ACB8E5D2D6CE53FDB2F3CF8710A5F8F78578D5254BC6F">https://wuying.aliyun.com/native-solution/cloud-flow/view?id=a-075nu7bcqim2wvxli&amp;token=8141B1A674D48ACB8E5D2D6CE53FDB2F3CF8710A5F8F78578D5254BC6F</a>******</para>
            /// </summary>
            [NameInMap("AccessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-02-08T03:52Z</para>
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public int? EffectTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-12-05 14:28:20</para>
            /// </summary>
            [NameInMap("UrlExpireTime")]
            [Validation(Required=false)]
            public string UrlExpireTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter ProductType is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
