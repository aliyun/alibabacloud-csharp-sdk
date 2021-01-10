// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryVideoPoseJobListResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryVideoPoseJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryVideoPoseJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryVideoPoseJobListResponseBodyJobList JobList { get; set; }
        public class QueryVideoPoseJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryVideoPoseJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryVideoPoseJobListResponseBodyJobListJob : TeaModel {
                [NameInMap("DataFile")]
                [Validation(Required=false)]
                public QueryVideoPoseJobListResponseBodyJobListJobDataFile DataFile { get; set; }
                public class QueryVideoPoseJobListResponseBodyJobListJobDataFile : TeaModel {
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                };

                [NameInMap("VideoFile")]
                [Validation(Required=false)]
                public QueryVideoPoseJobListResponseBodyJobListJobVideoFile VideoFile { get; set; }
                public class QueryVideoPoseJobListResponseBodyJobListJobVideoFile : TeaModel {
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                };

            }
        };

    }

}
