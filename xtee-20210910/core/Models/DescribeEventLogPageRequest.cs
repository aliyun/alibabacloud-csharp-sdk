// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventLogPageRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The account ID (request_param.accountId). The value can be up to 50 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180650758xxxxxxx</para>
        /// </summary>
        [NameInMap("accountIdPRP")]
        [Validation(Required=false)]
        public string AccountIdPRP { get; set; }

        /// <summary>
        /// <para>The start timestamp of the log. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1737101348000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The first full-text match condition. The value can be up to 30 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition1AL")]
        [Validation(Required=false)]
        public string Condition1AL { get; set; }

        /// <summary>
        /// <para>The second full-text match condition. The value can be up to 30 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition2AL")]
        [Validation(Required=false)]
        public string Condition2AL { get; set; }

        /// <summary>
        /// <para>The third full-text match condition. The value can be up to 30 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("condition3AL")]
        [Validation(Required=false)]
        public string Condition3AL { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The device type (request_param.deviceType). Example values: 1: PC. 2: MOBILE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("deviceTypeLRP")]
        [Validation(Required=false)]
        public string DeviceTypeLRP { get; set; }

        /// <summary>
        /// <para>The email address (request_param.email). The value can be up to 100 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@123.com">xxxx@123.com</a></para>
        /// </summary>
        [NameInMap("emailPRP")]
        [Validation(Required=false)]
        public string EmailPRP { get; set; }

        /// <summary>
        /// <para>The end time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746669075000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The logon failure reason (-request_param.failReason).</para>
        /// 
        /// <b>Example:</b>
        /// <para>wrongPassword</para>
        /// </summary>
        [NameInMap("failReasonLRP")]
        [Validation(Required=false)]
        public string FailReasonLRP { get; set; }

        /// <summary>
        /// <para>The IP address (request_param.ip). The value can be up to 20 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>168.168.168.168</para>
        /// </summary>
        [NameInMap("ipPRP")]
        [Validation(Required=false)]
        public string IpPRP { get; set; }

        /// <summary>
        /// <para>The logon success flag (request_param.loginResult).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("loginResultARP")]
        [Validation(Required=false)]
        public string LoginResultARP { get; set; }

        /// <summary>
        /// <para>The logon authentication method (-request_param.loginType).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PASSWORD</para>
        /// </summary>
        [NameInMap("loginTypeLRP")]
        [Validation(Required=false)]
        public string LoginTypeLRP { get; set; }

        /// <summary>
        /// <para>The device MAC address (-request_param.mac). The value can be up to 30 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00-1C-F0-1D-A7-81</para>
        /// </summary>
        [NameInMap("macPRP")]
        [Validation(Required=false)]
        public string MacPRP { get; set; }

        /// <summary>
        /// <para>The phone number (supports MD5: request_param.mobile/request_param.mobileMd5). The value can be up to 30 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards. The search is performed based on the mobile and mobileMd5 fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17600000000</para>
        /// </summary>
        [NameInMap("mobilePRP")]
        [Validation(Required=false)]
        public string MobilePRP { get; set; }

        /// <summary>
        /// <para>The account nickname (request_param.nickName). The value can be up to 50 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试xx</para>
        /// </summary>
        [NameInMap("nickNamePRP")]
        [Validation(Required=false)]
        public string NickNamePRP { get; set; }

        /// <summary>
        /// <para>The operation source (request_param.operateSource). Example values: 1: PC. 2: H5. 3: App.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("operateSourceLRP")]
        [Validation(Required=false)]
        public string OperateSourceLRP { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The referer (-request_param.refer). The value can be up to 50 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refer</para>
        /// </summary>
        [NameInMap("referPRP")]
        [Validation(Required=false)]
        public string ReferPRP { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The account registration IP address (request_param.registerIp). The value can be up to 20 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>168.168.168.168</para>
        /// </summary>
        [NameInMap("registerIpPRP")]
        [Validation(Required=false)]
        public string RegisterIpPRP { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD6B08EC-1B44-5378-8838-C76A36415C55</para>
        /// </summary>
        [NameInMap("reqIdPBS")]
        [Validation(Required=false)]
        public string ReqIdPBS { get; set; }

        /// <summary>
        /// <para>The end value of the score range (score). Only non-negative integers are allowed. The end value must be greater than the start value. Both boundaries are inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("scoreEBS")]
        [Validation(Required=false)]
        public int? ScoreEBS { get; set; }

        /// <summary>
        /// <para>The start value of the score range (score). Only non-negative integers are allowed. The end value must be greater than the start value. Both boundaries are inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scoreSBS")]
        [Validation(Required=false)]
        public int? ScoreSBS { get; set; }

        /// <summary>
        /// <para>The event name (instance_id).</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_afghcf6411</para>
        /// </summary>
        [NameInMap("serviceABS")]
        [Validation(Required=false)]
        public string ServiceABS { get; set; }

        /// <summary>
        /// <para>The risk label (tags). The data is obtained from DescribeTagsList.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg0001</para>
        /// </summary>
        [NameInMap("tagsLBS")]
        [Validation(Required=false)]
        public string TagsLBS { get; set; }

        /// <summary>
        /// <para>The device ID (device_info.umid).</para>
        /// 
        /// <b>Example:</b>
        /// <para>设备ID</para>
        /// </summary>
        [NameInMap("umidPDI")]
        [Validation(Required=false)]
        public string UmidPDI { get; set; }

        /// <summary>
        /// <para>The user agent (-request_param.userAgent). The value can be up to 50 characters in length and supports the &quot;\*&quot; and &quot;?&quot; wildcards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00-1C-F0-1D-A7-81</para>
        /// </summary>
        [NameInMap("userAgentPRP")]
        [Validation(Required=false)]
        public string UserAgentPRP { get; set; }

        /// <summary>
        /// <para>The account name type for the logon scenario (-request_param.userNameType).</para>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("userNameTypeLRP")]
        [Validation(Required=false)]
        public string UserNameTypeLRP { get; set; }

    }

}
