// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cdn_log_access_l1</b>: access logs of L1 Dynamic Route for CDN (DCDN) points of presence (POPs)</description></item>
        /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
        /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The region where Log Service resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b></description></item>
        /// <item><description><b>cn-shanghai</b></description></item>
        /// <item><description><b>cn-qingdao</b></description></item>
        /// <item><description><b>cn-beijing</b></description></item>
        /// <item><description><b>cn-zhangjiakou</b></description></item>
        /// <item><description><b>cn-shenzhen</b></description></item>
        /// <item><description><b>eu-central-1</b></description></item>
        /// <item><description><b>us-west-1</b></description></item>
        /// <item><description><b>ap-south-1</b></description></item>
        /// <item><description><b>ap-southeast-1</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
