// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDemonstrationForCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDemonstrationForCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetDemonstrationForCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("DemonstrationList")]
            [Validation(Required=false)]
            public List<GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList> DemonstrationList { get; set; }
            public class GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList : TeaModel {
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public int? AudioId { get; set; }

                [NameInMap("DemoAudio")]
                [Validation(Required=false)]
                public string DemoAudio { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
