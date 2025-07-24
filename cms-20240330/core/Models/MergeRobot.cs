// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeRobot : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public MergeRobotExtend Extend { get; set; }
        public class MergeRobotExtend : TeaModel {
            [NameInMap("cardTemplate")]
            [Validation(Required=false)]
            public string CardTemplate { get; set; }

            [NameInMap("dailyNoc")]
            [Validation(Required=false)]
            public bool? DailyNoc { get; set; }

            [NameInMap("dailyNocTime")]
            [Validation(Required=false)]
            public string DailyNocTime { get; set; }

            [NameInMap("dingSignKey")]
            [Validation(Required=false)]
            public string DingSignKey { get; set; }

            [NameInMap("enableOutgoing")]
            [Validation(Required=false)]
            public bool? EnableOutgoing { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
