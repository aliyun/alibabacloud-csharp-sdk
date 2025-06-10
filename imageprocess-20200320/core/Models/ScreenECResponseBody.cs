// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenECResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenECResponseBodyData Data { get; set; }
        public class ScreenECResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenECResponseBodyDataLesion Lesion { get; set; }
            public class ScreenECResponseBodyDataLesion : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BenignVolume")]
                [Validation(Required=false)]
                public string BenignVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EcVolume")]
                [Validation(Required=false)]
                public string EcVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>26814</para>
                /// </summary>
                [NameInMap("EsoVolume")]
                [Validation(Required=false)]
                public string EsoVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR</a>****</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Possibilities")]
                [Validation(Required=false)]
                public List<string> Possibilities { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B65AC8E-311A-1ED1-BBE6-6AA6D35D31A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
