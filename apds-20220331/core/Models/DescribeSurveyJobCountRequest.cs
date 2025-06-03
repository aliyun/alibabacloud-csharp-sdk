// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class DescribeSurveyJobCountRequest : TeaModel {
        [NameInMap("channelList")]
        [Validation(Required=false)]
        public List<string> ChannelList { get; set; }

        [NameInMap("cloudTypeList")]
        [Validation(Required=false)]
        public List<string> CloudTypeList { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
