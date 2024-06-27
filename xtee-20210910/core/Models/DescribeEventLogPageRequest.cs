// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventLogPageRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("accountIdPRP")]
        [Validation(Required=false)]
        public string AccountIdPRP { get; set; }

        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("condition1AL")]
        [Validation(Required=false)]
        public string Condition1AL { get; set; }

        [NameInMap("condition2AL")]
        [Validation(Required=false)]
        public string Condition2AL { get; set; }

        [NameInMap("condition3AL")]
        [Validation(Required=false)]
        public string Condition3AL { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("deviceTypeLRP")]
        [Validation(Required=false)]
        public string DeviceTypeLRP { get; set; }

        [NameInMap("emailPRP")]
        [Validation(Required=false)]
        public string EmailPRP { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("failReasonLRP")]
        [Validation(Required=false)]
        public string FailReasonLRP { get; set; }

        [NameInMap("ipPRP")]
        [Validation(Required=false)]
        public string IpPRP { get; set; }

        [NameInMap("loginResultARP")]
        [Validation(Required=false)]
        public string LoginResultARP { get; set; }

        [NameInMap("loginTypeLRP")]
        [Validation(Required=false)]
        public string LoginTypeLRP { get; set; }

        [NameInMap("macPRP")]
        [Validation(Required=false)]
        public string MacPRP { get; set; }

        [NameInMap("mobilePRP")]
        [Validation(Required=false)]
        public string MobilePRP { get; set; }

        [NameInMap("nickNamePRP")]
        [Validation(Required=false)]
        public string NickNamePRP { get; set; }

        [NameInMap("operateSourceLRP")]
        [Validation(Required=false)]
        public string OperateSourceLRP { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("referPRP")]
        [Validation(Required=false)]
        public string ReferPRP { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("registerIpPRP")]
        [Validation(Required=false)]
        public string RegisterIpPRP { get; set; }

        [NameInMap("reqIdPBS")]
        [Validation(Required=false)]
        public string ReqIdPBS { get; set; }

        [NameInMap("scoreEBS")]
        [Validation(Required=false)]
        public int? ScoreEBS { get; set; }

        [NameInMap("scoreSBS")]
        [Validation(Required=false)]
        public int? ScoreSBS { get; set; }

        [NameInMap("serviceABS")]
        [Validation(Required=false)]
        public string ServiceABS { get; set; }

        [NameInMap("tagsLBS")]
        [Validation(Required=false)]
        public string TagsLBS { get; set; }

        [NameInMap("umidPDI")]
        [Validation(Required=false)]
        public string UmidPDI { get; set; }

        [NameInMap("userAgentPRP")]
        [Validation(Required=false)]
        public string UserAgentPRP { get; set; }

        [NameInMap("userNameTypeLRP")]
        [Validation(Required=false)]
        public string UserNameTypeLRP { get; set; }

    }

}
