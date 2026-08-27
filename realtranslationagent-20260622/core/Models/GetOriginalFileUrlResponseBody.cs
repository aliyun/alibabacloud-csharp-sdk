// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class GetOriginalFileUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOriginalFileUrlResponseBodyData Data { get; set; }
        public class GetOriginalFileUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://gtm-translate-service-prod.oss-cn-zhangjiakou.aliyuncs.com/translations/replaced/a_file_992736840.pptx?Expires=1782738716&OSSAccessKeyId=STS.NZm6TgFWU2sgpBxs2UD154B9w&Signature=uPORIIsYjiwRFzoyNUN8Htnwdfc%3D&security-token=CAIS3gJ1q6Ft5B2yfSjIr5nYfe7Tq4h0hbGMcmTJlzIASL4Z24eSlTz2IHhMf3FtAuwft%2FU0mWFW7foSlrp6SJtIXleCZtF94oxN9h2gb4fb4woBanWd08%2FLI3OaLjKm9u2wCryLYbGwU%2FOpbE%2B%2B5U0X6LDmdDKkckW4OJmS8%2FBOZcgWWQ%2FKBlgvRq0hRG1YpdQdKGHaONu0LxfumRCwNkdzvRdmgm4NgsbWgO%2Fks0OC1ACnmrdM%2FdupesL0MPMBZskvD42Hu8VtbbfE3SJq7BxHybx7lqQs%2B02c5onGWwQKv0zfYrGJo4M0cF9jLqcmHutYtvH6jvlxpuGWjInt1RdGMKRHXj7YAZy63dDYCHRtm2ect12R0R3spTPvXvGd22tMCfkrqw7Ahz2PACvRGM5dh0AbW042tZHwaHNHYcJrPu9YH1QLobvGc7TkCSYBIdG7lRJ8EPtayyu0U3F2gASJGhqAATkIHCzHZWyr%2F8WJFcinsIxuI8iYoH3pOTZ2HJgDW38Zbu0NqMZmH%2BbRahVPiN7s4ckYmF50hCbgXt%2BdD9R6jB%2BkNufrVtN%2FAVgRMLOeEn2FZF0CCLlyjaIqq8QIxaPpDSLxpV6wZSh5enenoKm%2B1wunWRdd0gwG03k%2F4RCcDbb%2FIAA%3D">https://gtm-translate-service-prod.oss-cn-zhangjiakou.aliyuncs.com/translations/replaced/a_file_992736840.pptx?Expires=1782738716&amp;OSSAccessKeyId=STS.NZm6TgFWU2sgpBxs2UD154B9w&amp;Signature=uPORIIsYjiwRFzoyNUN8Htnwdfc%3D&amp;security-token=CAIS3gJ1q6Ft5B2yfSjIr5nYfe7Tq4h0hbGMcmTJlzIASL4Z24eSlTz2IHhMf3FtAuwft%2FU0mWFW7foSlrp6SJtIXleCZtF94oxN9h2gb4fb4woBanWd08%2FLI3OaLjKm9u2wCryLYbGwU%2FOpbE%2B%2B5U0X6LDmdDKkckW4OJmS8%2FBOZcgWWQ%2FKBlgvRq0hRG1YpdQdKGHaONu0LxfumRCwNkdzvRdmgm4NgsbWgO%2Fks0OC1ACnmrdM%2FdupesL0MPMBZskvD42Hu8VtbbfE3SJq7BxHybx7lqQs%2B02c5onGWwQKv0zfYrGJo4M0cF9jLqcmHutYtvH6jvlxpuGWjInt1RdGMKRHXj7YAZy63dDYCHRtm2ect12R0R3spTPvXvGd22tMCfkrqw7Ahz2PACvRGM5dh0AbW042tZHwaHNHYcJrPu9YH1QLobvGc7TkCSYBIdG7lRJ8EPtayyu0U3F2gASJGhqAATkIHCzHZWyr%2F8WJFcinsIxuI8iYoH3pOTZ2HJgDW38Zbu0NqMZmH%2BbRahVPiN7s4ckYmF50hCbgXt%2BdD9R6jB%2BkNufrVtN%2FAVgRMLOeEn2FZF0CCLlyjaIqq8QIxaPpDSLxpV6wZSh5enenoKm%2B1wunWRdd0gwG03k%2F4RCcDbb%2FIAA%3D</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The expiration time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774147442</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>translated_a_file.pptx</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F80A58B-DFBA-55A1-B9D2-819B32904127</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
