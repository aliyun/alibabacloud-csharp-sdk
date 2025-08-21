// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetJiangSuTelecomDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26C9C3D0-160D-5CDE-BF7A-B3C8D14AA949</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetJiangSuTelecomDataResponseBodyResult Result { get; set; }
        public class GetJiangSuTelecomDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://jiangsu-telecom.oss-cn-zhangjiakou.aliyuncs.com/jiangsuTelecom/jiangsu_telecom_2024-11-06_data.xls?Expires=1731056700&OSSAccessKeyId=STS.NUqZx6e1HjWYHhYwyDqbRNySp&Signature=wqMK%2Bspo08cg7xDIrzJdgFpZT3U%3D&security-token=CAIS6wJ1q6Ft5B2yfSjIr5bEEcKCiO5p3ZWySk7ok3kRfe1%2Bobz4kjz2IHhMeXJsBuketv42nmxV7%2FoblrN0UIQAT1HPbsZsq84Pq1%2F4O9GY%2FpXrseBZ08VJ18si00SpsvXJasDVEfn%2FGJ70GX2m%2BwZ3xbzlD0bAO3WuLZyOj7N%2Bc90TRXPWRDFaBdBQVGAAwY1gQhm3D%2Fu2NQPwiWf9FVdhvhEG6Vly8qOi2MaRmHG85R%2FYsrZL%2B9uuc8b5P5A0Y8wlAo6PsbYoJvab4kl58ANX8ap6tqtA9Arcs8uVa1sruE3ebrGIrYQ3dFUgPPRnQvIdtrP1nvt5%2FOXS0p%2Fs01NHNOpWXiLTAoe7247OBeiqO8p%2FKeyjZGQuOTooxiRr2elNRQX4VGsiE7JJQhf7CU293KO0YeZxdAR%2FoOMPnzRBdA2yRaA0rjOmtJPBTFOEIL7ymXpDY8bnsxtwDRYu1%2BXrCqUee2Ik3j4vnOf9Je0agAEDuPfR8GLB8uVv4ZCGRRAM5mV3gKCxl07flVk1UPsxMZWBeVwwALT34lxk4x6ivWA7ZXjXdMmIapup%2FEb6UU%2BWhJH1G4sevkw5%2BGb8h8aRjJHBoxB4YLXNTEb5Rk6sVv%2BoCfkljy3%2FWImWGIMigurkAfOIBgUSql8JgFTxQrOHbiAA">http://jiangsu-telecom.oss-cn-zhangjiakou.aliyuncs.com/jiangsuTelecom/jiangsu_telecom_2024-11-06_data.xls?Expires=1731056700&amp;OSSAccessKeyId=STS.NUqZx6e1HjWYHhYwyDqbRNySp&amp;Signature=wqMK%2Bspo08cg7xDIrzJdgFpZT3U%3D&amp;security-token=CAIS6wJ1q6Ft5B2yfSjIr5bEEcKCiO5p3ZWySk7ok3kRfe1%2Bobz4kjz2IHhMeXJsBuketv42nmxV7%2FoblrN0UIQAT1HPbsZsq84Pq1%2F4O9GY%2FpXrseBZ08VJ18si00SpsvXJasDVEfn%2FGJ70GX2m%2BwZ3xbzlD0bAO3WuLZyOj7N%2Bc90TRXPWRDFaBdBQVGAAwY1gQhm3D%2Fu2NQPwiWf9FVdhvhEG6Vly8qOi2MaRmHG85R%2FYsrZL%2B9uuc8b5P5A0Y8wlAo6PsbYoJvab4kl58ANX8ap6tqtA9Arcs8uVa1sruE3ebrGIrYQ3dFUgPPRnQvIdtrP1nvt5%2FOXS0p%2Fs01NHNOpWXiLTAoe7247OBeiqO8p%2FKeyjZGQuOTooxiRr2elNRQX4VGsiE7JJQhf7CU293KO0YeZxdAR%2FoOMPnzRBdA2yRaA0rjOmtJPBTFOEIL7ymXpDY8bnsxtwDRYu1%2BXrCqUee2Ik3j4vnOf9Je0agAEDuPfR8GLB8uVv4ZCGRRAM5mV3gKCxl07flVk1UPsxMZWBeVwwALT34lxk4x6ivWA7ZXjXdMmIapup%2FEb6UU%2BWhJH1G4sevkw5%2BGb8h8aRjJHBoxB4YLXNTEb5Rk6sVv%2BoCfkljy3%2FWImWGIMigurkAfOIBgUSql8JgFTxQrOHbiAA</a></para>
            /// </summary>
            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

        }

    }

}
