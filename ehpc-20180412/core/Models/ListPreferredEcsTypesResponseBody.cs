// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListPreferredEcsTypesResponseBody : TeaModel {
        [NameInMap("Series")]
        [Validation(Required=false)]
        public List<ListPreferredEcsTypesResponseBodySeries> Series { get; set; }
        public class ListPreferredEcsTypesResponseBodySeries : TeaModel {
            [NameInMap("SeriesId")]
            [Validation(Required=false)]
            public string SeriesId { get; set; }

            [NameInMap("SeriesName")]
            [Validation(Required=false)]
            public string SeriesName { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public ListPreferredEcsTypesResponseBodySeriesRoles Roles { get; set; }
            public class ListPreferredEcsTypesResponseBodySeriesRoles : TeaModel {
                [NameInMap("Manager")]
                [Validation(Required=false)]
                public List<string> Manager { get; set; }
                [NameInMap("Compute")]
                [Validation(Required=false)]
                public List<string> Compute { get; set; }
                [NameInMap("Login")]
                [Validation(Required=false)]
                public List<string> Login { get; set; }
            };

        }

        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
