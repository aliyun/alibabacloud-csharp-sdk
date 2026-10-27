// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardRequest : TeaModel {
        /// <summary>
        /// <para>The target cloud service instance ID for the check item.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The subtype of the cloud service.</para>
        /// </summary>
        [NameInMap("InstanceSubTypes")]
        [Validation(Required=false)]
        public List<string> InstanceSubTypes { get; set; }

        /// <summary>
        /// <para>The asset type of the cloud service.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The list of task sources.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The list of cloud vendors. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud.</description></item>
        /// <item><description><b>TENCENT</b>: Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
        /// <item><description><b>MICROSOFT</b>: Azure.</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
