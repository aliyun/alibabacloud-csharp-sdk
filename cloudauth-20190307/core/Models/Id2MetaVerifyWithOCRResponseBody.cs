// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaVerifyWithOCRResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, any other value indicates failure.
        /// <b>Important</b></para>
        /// <list type="bullet">
        /// <item><description>This parameter indicates whether the API was called correctly. For detailed return code explanations, please refer to the error codes.</description></item>
        /// <item><description>Check the business verification results through the fields in ResultObject.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>API call return message.
        /// <b>Important</b>
        /// This parameter only indicates if there was an exception with the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Id2MetaVerifyWithOCRResponseBodyResultObject ResultObject { get; set; }
        public class Id2MetaVerifyWithOCRResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Identity verification result:</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent</description></item>
            /// <item><description>2: Inconsistent</description></item>
            /// <item><description>3: No record found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>{&quot;address&quot;:&quot;Zhejiang Province, Hangzhou City, Yu*****&quot;,&quot;birthDate&quot;:&quot;19901226&quot;,&quot;certName&quot;:&quot;Zhang San&quot;,&quot;certNo&quot;:&quot;1234561990122*****&quot;,&quot;nationality&quot;:&quot;Han&quot;,&quot;authority&quot;:&quot;xxx Public Security Bureau&quot;,&quot;startDate&quot;:&quot;20201130&quot;,&quot;endDate&quot;:&quot;20301130&quot;}</para>
            /// 
            /// <b>Example:</b>
            /// <para>OCR读取的身份证信息。</para>
            /// </summary>
            [NameInMap("CardInfo")]
            [Validation(Required=false)]
            public string CardInfo { get; set; }

        }

    }

}
