// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class ListSurveyJobsRequest : TeaModel {
        [NameInMap("channelList")]
        [Validation(Required=false)]
        public List<string> ChannelList { get; set; }

        [NameInMap("cloudTypeList")]
        [Validation(Required=false)]
        public List<string> CloudTypeList { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public List<string> Region { get; set; }

        [NameInMap("surveyRange")]
        [Validation(Required=false)]
        public string SurveyRange { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
