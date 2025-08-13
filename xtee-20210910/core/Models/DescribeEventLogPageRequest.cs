// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventLogPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>180650758xxxxxxx</para>
        /// </summary>
        [NameInMap("accountIdPRP")]
        [Validation(Required=false)]
        public string AccountIdPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1737101348000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition1AL")]
        [Validation(Required=false)]
        public string Condition1AL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition2AL")]
        [Validation(Required=false)]
        public string Condition2AL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition3AL")]
        [Validation(Required=false)]
        public string Condition3AL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("deviceTypeLRP")]
        [Validation(Required=false)]
        public string DeviceTypeLRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@123.com">xxxx@123.com</a></para>
        /// </summary>
        [NameInMap("emailPRP")]
        [Validation(Required=false)]
        public string EmailPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1746669075000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wrongPassword</para>
        /// </summary>
        [NameInMap("failReasonLRP")]
        [Validation(Required=false)]
        public string FailReasonLRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168.168.168.168</para>
        /// </summary>
        [NameInMap("ipPRP")]
        [Validation(Required=false)]
        public string IpPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("loginResultARP")]
        [Validation(Required=false)]
        public string LoginResultARP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PASSWORD</para>
        /// </summary>
        [NameInMap("loginTypeLRP")]
        [Validation(Required=false)]
        public string LoginTypeLRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00-1C-F0-1D-A7-81</para>
        /// </summary>
        [NameInMap("macPRP")]
        [Validation(Required=false)]
        public string MacPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17600000000</para>
        /// </summary>
        [NameInMap("mobilePRP")]
        [Validation(Required=false)]
        public string MobilePRP { get; set; }

        [NameInMap("nickNamePRP")]
        [Validation(Required=false)]
        public string NickNamePRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("operateSourceLRP")]
        [Validation(Required=false)]
        public string OperateSourceLRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>refer</para>
        /// </summary>
        [NameInMap("referPRP")]
        [Validation(Required=false)]
        public string ReferPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168.168.168.168</para>
        /// </summary>
        [NameInMap("registerIpPRP")]
        [Validation(Required=false)]
        public string RegisterIpPRP { get; set; }

        /// <summary>
        /// <para>requestId。</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD6B08EC-1B44-5378-8838-C76A36415C55</para>
        /// </summary>
        [NameInMap("reqIdPBS")]
        [Validation(Required=false)]
        public string ReqIdPBS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("scoreEBS")]
        [Validation(Required=false)]
        public int? ScoreEBS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scoreSBS")]
        [Validation(Required=false)]
        public int? ScoreSBS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>de_afghcf6411</para>
        /// </summary>
        [NameInMap("serviceABS")]
        [Validation(Required=false)]
        public string ServiceABS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg0001</para>
        /// </summary>
        [NameInMap("tagsLBS")]
        [Validation(Required=false)]
        public string TagsLBS { get; set; }

        [NameInMap("umidPDI")]
        [Validation(Required=false)]
        public string UmidPDI { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00-1C-F0-1D-A7-81</para>
        /// </summary>
        [NameInMap("userAgentPRP")]
        [Validation(Required=false)]
        public string UserAgentPRP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("userNameTypeLRP")]
        [Validation(Required=false)]
        public string UserNameTypeLRP { get; set; }

    }

}
