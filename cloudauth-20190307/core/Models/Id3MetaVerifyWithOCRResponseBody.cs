// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyWithOCRResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success. Other values indicate failure. <b>Important</b></para>
        /// <list type="bullet">
        /// <item><description>This parameter indicates only whether the API call was made correctly. For more information about return codes, see error codes.</description></item>
        /// <item><description>Check the fields in ResultObject for the business verification result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message of the API call. This parameter indicates only whether an exception occurred during the API call.</para>
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
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Id3MetaVerifyWithOCRResponseBodyResultObject ResultObject { get; set; }
        public class Id3MetaVerifyWithOCRResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The identity verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: consistent.</description></item>
            /// <item><description>2: inconsistent.</description></item>
            /// <item><description>3: no record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>{&quot;address&quot;:&quot;浙江省杭州市余*****&quot;,&quot;birthDate&quot;:&quot;19901226&quot;,&quot;certName&quot;:&quot;张三&quot;,&quot;certNo&quot;:&quot;1234561990122*****&quot;,&quot;nationality&quot;:&quot;汉&quot;,&quot;authority&quot;:&quot;xxx公安局&quot;,&quot;startDate&quot;:&quot;20201130&quot;,&quot;endDate&quot;:&quot;20301130&quot;}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OCR读取的身份证信息。</para>
            /// </summary>
            [NameInMap("CardInfo")]
            [Validation(Required=false)]
            public string CardInfo { get; set; }

            /// <summary>
            /// <para>The face comparison score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;verifyScore&quot;: 50.28594166529785
            /// }</para>
            /// </summary>
            [NameInMap("FaceDetail")]
            [Validation(Required=false)]
            public string FaceDetail { get; set; }

        }

    }

}
