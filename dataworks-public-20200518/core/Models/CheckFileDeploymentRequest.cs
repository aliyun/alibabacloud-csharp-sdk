// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CheckFileDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://result.aliyun.com/?checkerInstanceId=">https://result.aliyun.com/?checkerInstanceId=</a></para>
        /// </summary>
        [NameInMap("CheckDetailUrl")]
        [Validation(Required=false)]
        public string CheckDetailUrl { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the file checker belongs. You can obtain the ID from the CheckerInstanceId parameter in the check event logs returned by DataWorks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66_123455623_2</para>
        /// </summary>
        [NameInMap("CheckerInstanceId")]
        [Validation(Required=false)]
        public string CheckerInstanceId { get; set; }

        /// <summary>
        /// <para>The check status of the file that you want to deploy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The file passes the check.</description></item>
        /// <item><description>WARN: The file passes the check, but an alert is reported.</description></item>
        /// <item><description>FAIL: The file fails the check.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
