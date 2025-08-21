// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonAlarmRecordStatisticsDistributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetEmonAlarmRecordStatisticsDistributeResponseBodyResult Result { get; set; }
        public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResult : TeaModel {
            [NameInMap("alarmGroup")]
            [Validation(Required=false)]
            public string AlarmGroup { get; set; }

            [NameInMap("alarmGroupTotal")]
            [Validation(Required=false)]
            public List<GetEmonAlarmRecordStatisticsDistributeResponseBodyResultAlarmGroupTotal> AlarmGroupTotal { get; set; }
            public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResultAlarmGroupTotal : TeaModel {
                [NameInMap("alarmGroup")]
                [Validation(Required=false)]
                public string AlarmGroup { get; set; }

                [NameInMap("compare")]
                [Validation(Required=false)]
                public string Compare { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public int? Today { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yesterday")]
                [Validation(Required=false)]
                public int? Yesterday { get; set; }

            }

            [NameInMap("channelTotal")]
            [Validation(Required=false)]
            public List<GetEmonAlarmRecordStatisticsDistributeResponseBodyResultChannelTotal> ChannelTotal { get; set; }
            public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResultChannelTotal : TeaModel {
                [NameInMap("alarmGroup")]
                [Validation(Required=false)]
                public string AlarmGroup { get; set; }

                [NameInMap("compare")]
                [Validation(Required=false)]
                public string Compare { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public int? Today { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yesterday")]
                [Validation(Required=false)]
                public int? Yesterday { get; set; }

            }

            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("levelTotal")]
            [Validation(Required=false)]
            public List<GetEmonAlarmRecordStatisticsDistributeResponseBodyResultLevelTotal> LevelTotal { get; set; }
            public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResultLevelTotal : TeaModel {
                [NameInMap("alarmGroup")]
                [Validation(Required=false)]
                public string AlarmGroup { get; set; }

                [NameInMap("compare")]
                [Validation(Required=false)]
                public string Compare { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public int? Today { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yesterday")]
                [Validation(Required=false)]
                public int? Yesterday { get; set; }

            }

            [NameInMap("receiverTotal")]
            [Validation(Required=false)]
            public List<GetEmonAlarmRecordStatisticsDistributeResponseBodyResultReceiverTotal> ReceiverTotal { get; set; }
            public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResultReceiverTotal : TeaModel {
                [NameInMap("alarmGroup")]
                [Validation(Required=false)]
                public string AlarmGroup { get; set; }

                [NameInMap("compare")]
                [Validation(Required=false)]
                public string Compare { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public int? Today { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yesterday")]
                [Validation(Required=false)]
                public int? Yesterday { get; set; }

            }

            [NameInMap("statistics")]
            [Validation(Required=false)]
            public List<GetEmonAlarmRecordStatisticsDistributeResponseBodyResultStatistics> Statistics { get; set; }
            public class GetEmonAlarmRecordStatisticsDistributeResponseBodyResultStatistics : TeaModel {
                [NameInMap("alarmGroup")]
                [Validation(Required=false)]
                public string AlarmGroup { get; set; }

                [NameInMap("compare")]
                [Validation(Required=false)]
                public string Compare { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public int? Today { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yesterday")]
                [Validation(Required=false)]
                public int? Yesterday { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
