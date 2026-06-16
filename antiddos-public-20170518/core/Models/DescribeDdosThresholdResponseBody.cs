// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosThresholdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9B3C090-55AD-59C6-979E-FCFD81E7D9E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Thresholds")]
        [Validation(Required=false)]
        public DescribeDdosThresholdResponseBodyThresholds Thresholds { get; set; }
        public class DescribeDdosThresholdResponseBodyThresholds : TeaModel {
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public List<DescribeDdosThresholdResponseBodyThresholdsThreshold> Threshold { get; set; }
            public class DescribeDdosThresholdResponseBodyThresholdsThreshold : TeaModel {
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public int? Bps { get; set; }

                [NameInMap("DdosType")]
                [Validation(Required=false)]
                public string DdosType { get; set; }

                [NameInMap("ElasticBps")]
                [Validation(Required=false)]
                public int? ElasticBps { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("IsAuto")]
                [Validation(Required=false)]
                public bool? IsAuto { get; set; }

                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public int? MaxBps { get; set; }

                [NameInMap("MaxPps")]
                [Validation(Required=false)]
                public int? MaxPps { get; set; }

                [NameInMap("Pps")]
                [Validation(Required=false)]
                public int? Pps { get; set; }

            }

        }

    }

}
