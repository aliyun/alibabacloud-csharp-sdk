// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ProvisionAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the deployment target belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("OriginTargetId")]
        [Validation(Required=false)]
        public string OriginTargetId { get; set; }

        /// <summary>
        /// <para>The ID of the task target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The target type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD-Account: The task target is an account in a resource directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
