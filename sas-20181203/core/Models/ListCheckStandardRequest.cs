// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardRequest : TeaModel {
        /// <summary>
        /// <para>The instance IDs of the cloud services to which the check items belong.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The subtypes of cloud services.</para>
        /// </summary>
        [NameInMap("InstanceSubTypes")]
        [Validation(Required=false)]
        public List<string> InstanceSubTypes { get; set; }

        /// <summary>
        /// <para>The asset types of cloud services.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>List of task sources.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The cloud service providers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud.</description></item>
        /// <item><description><b>TENCENT</b>: Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
        /// <item><description><b>MICROSOFT</b>: Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
