// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeCardVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, all others indicate failure.
        /// Important</para>
        /// <list type="bullet">
        /// <item><description>This parameter indicates whether the interface was called correctly. For detailed return code explanations, please refer to the error codes.</description></item>
        /// <item><description>Please check the business verification results through the fields in ResultObject.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Interface call return message.
        /// Important</para>
        /// <list type="bullet">
        /// <item><description>This parameter only indicates whether there was an exception with the interface.</description></item>
        /// </list>
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
        /// <para>Result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeCardVerifyResponseBodyResultObject ResultObject { get; set; }
        public class DescribeCardVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Identity verification result:</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent</description></item>
            /// <item><description>2: Inconsistent</description></item>
            /// <item><description>3: No Record Found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Submitted ID card information for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;address&quot;:&quot;浙江省杭州市余杭区文一西路969号&quot;,&quot;birthDate&quot;:&quot;19901226&quot;,&quot;certName&quot;:&quot;张三&quot;,&quot;certNo&quot;:&quot;1234561990122*****&quot;,&quot;nationality&quot;:&quot;汉&quot;,&quot;authority&quot;:&quot;xxx公安局&quot;,&quot;startDate&quot;:&quot;20201130&quot;,&quot;endDate&quot;:&quot;20301130&quot;}</para>
            /// </summary>
            [NameInMap("CardInfo")]
            [Validation(Required=false)]
            public string CardInfo { get; set; }

            /// <summary>
            /// <para>Image comparison score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;verifyScore&quot;: 50.28594166529785
            /// }</para>
            /// </summary>
            [NameInMap("FaceDetail")]
            [Validation(Required=false)]
            public string FaceDetail { get; set; }

            /// <summary>
            /// <para>ID card information read by OCR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;address&quot;:&quot;浙江省杭州市余杭区文一西路969号&quot;,&quot;birthDate&quot;:&quot;19901226&quot;,&quot;certName&quot;:&quot;张三&quot;,&quot;certNo&quot;:&quot;1234561990122*****&quot;,&quot;nationality&quot;:&quot;汉&quot;,&quot;authority&quot;:&quot;xxx公安局&quot;,&quot;startDate&quot;:&quot;20201130&quot;,&quot;endDate&quot;:&quot;20301130&quot;}</para>
            /// </summary>
            [NameInMap("OcrCardInfo")]
            [Validation(Required=false)]
            public string OcrCardInfo { get; set; }

            /// <summary>
            /// <para>Returned photo URLs.</para>
            /// <list type="bullet">
            /// <item><description>certUrl  Front side</description></item>
            /// <item><description>certNationalUrl  National emblem side</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;certUrl&quot;: &quot;<a href="https://cn-shanghai-aliyun-nmeta.cn-shanghai.oss.aliyuncs.com/verify/xxxxxxx/xxxxxxxxxx_ocridface_dbf2_normal.jpeg">https://cn-shanghai-aliyun-nmeta.cn-shanghai.oss.aliyuncs.com/verify/xxxxxxx/xxxxxxxxxx_ocridface_dbf2_normal.jpeg</a>&quot;,
            ///     &quot;certNationalUrl&quot;: &quot;<a href="https://cn-shanghai-aliyun-nmeta.cn-shanghai.oss.aliyuncs.com/verify/xxxxxxxxxx/xxxxxxxxxxx_ocridback_e8a3_normal.jpeg">https://cn-shanghai-aliyun-nmeta.cn-shanghai.oss.aliyuncs.com/verify/xxxxxxxxxx/xxxxxxxxxxx_ocridback_e8a3_normal.jpeg</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("PictureInfo")]
            [Validation(Required=false)]
            public string PictureInfo { get; set; }

        }

    }

}
