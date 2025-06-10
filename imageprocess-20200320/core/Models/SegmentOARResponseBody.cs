// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class SegmentOARResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentOARResponseBodyData Data { get; set; }
        public class SegmentOARResponseBodyData : TeaModel {
            [NameInMap("MaskList")]
            [Validation(Required=false)]
            public List<string> MaskList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=iB16ms28Y5mzB11ghYUd7upCi4">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=iB16ms28Y5mzB11ghYUd7upCi4</a>****</para>
            /// </summary>
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57784EDF-7322-1559-89C2-26A08570B26B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
