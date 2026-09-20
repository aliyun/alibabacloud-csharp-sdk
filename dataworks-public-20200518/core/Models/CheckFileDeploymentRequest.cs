// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CheckFileDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://result.aliyun.com/?checkerInstanceId=">https://result.aliyun.com/?checkerInstanceId=</a></para>
        /// </summary>
        [NameInMap("CheckDetailUrl")]
        [Validation(Required=false)]
        public string CheckDetailUrl { get; set; }

        /// <summary>
        /// <para>The instance ID to which the file checker belongs. You can obtain this value from the CheckerInstanceId field in the file publish check event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66_123455623_2</para>
        /// </summary>
        [NameInMap("CheckerInstanceId")]
        [Validation(Required=false)]
        public string CheckerInstanceId { get; set; }

        /// <summary>
        /// <para>The check status of the file pending deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The file passed the check.</description></item>
        /// <item><description>WARN: The file passed the check but has warnings.</description></item>
        /// <item><description>FAIL: The file failed the check.</description></item>
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
