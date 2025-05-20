// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class PushRpaTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>aliyunKp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AliyunKp")]
        [Validation(Required=false)]
        public string AliyunKp { get; set; }

        /// <summary>
        /// <para>apiType</para>
        /// 
        /// <b>Example:</b>
        /// <para>MPC</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>bid</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>inputData</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://wssq.sbj.cnipa.gov.cn:9080/tmsve/wssqsy_getCayzDl.xhtml">http://wssq.sbj.cnipa.gov.cn:9080/tmsve/wssqsy_getCayzDl.xhtml</a></para>
        /// </summary>
        [NameInMap("InputData")]
        [Validation(Required=false)]
        public string InputData { get; set; }

        /// <summary>
        /// <para>inputHtml</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InputHtml")]
        [Validation(Required=false)]
        public string InputHtml { get; set; }

        /// <summary>
        /// <para>inputScreenshot</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InputScreenshot")]
        [Validation(Required=false)]
        public string InputScreenshot { get; set; }

        /// <summary>
        /// <para>lang</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>modelDetailId</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ModelDetailId")]
        [Validation(Required=false)]
        public long? ModelDetailId { get; set; }

        /// <summary>
        /// <para>originalRequest</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OriginalRequest")]
        [Validation(Required=false)]
        public string OriginalRequest { get; set; }

        /// <summary>
        /// <para>outputData</para>
        /// </summary>
        [NameInMap("OutputData")]
        [Validation(Required=false)]
        public string OutputData { get; set; }

        /// <summary>
        /// <para>outputHtml</para>
        /// 
        /// <b>Example:</b>
        /// <div class=\\"photobox\\" id=\\"Layer3\\" style=\\"visibility: visible
        /// </summary>
        [NameInMap("OutputHtml")]
        [Validation(Required=false)]
        public string OutputHtml { get; set; }

        /// <summary>
        /// <para>outputScreenshot</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://dbu-nap-p-test.oss-cn-beijing.aliyuncs.com/202301/20230110/5782089/1673334129101-d111874e-f181-4d1c-8edc-83e789975329.jpg?Expires=1675926129&OSSAccessKeyId=hObpgEXoca42qH3V&Signature=------">http://dbu-nap-p-test.oss-cn-beijing.aliyuncs.com/202301/20230110/5782089/1673334129101-d111874e-f181-4d1c-8edc-83e789975329.jpg?Expires=1675926129&amp;OSSAccessKeyId=hObpgEXoca42qH3V&amp;Signature=------</a></para>
        /// </summary>
        [NameInMap("OutputScreenshot")]
        [Validation(Required=false)]
        public string OutputScreenshot { get; set; }

        /// <summary>
        /// <para>status</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>taskDetailId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskDetailId")]
        [Validation(Required=false)]
        public long? TaskDetailId { get; set; }

        /// <summary>
        /// <para>taskId</para>
        /// 
        /// <b>Example:</b>
        /// <para>5596654</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>userAccessKeyId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>userBid</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserBid")]
        [Validation(Required=false)]
        public string UserBid { get; set; }

        /// <summary>
        /// <para>userCallerParentId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCallerParentId")]
        [Validation(Required=false)]
        public long? UserCallerParentId { get; set; }

        /// <summary>
        /// <para>userCallerType</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCallerType")]
        [Validation(Required=false)]
        public string UserCallerType { get; set; }

        /// <summary>
        /// <para>userClientIp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>userKp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserKp")]
        [Validation(Required=false)]
        public string UserKp { get; set; }

        /// <summary>
        /// <para>userSecurityToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserSecurityToken")]
        [Validation(Required=false)]
        public string UserSecurityToken { get; set; }

    }

}
