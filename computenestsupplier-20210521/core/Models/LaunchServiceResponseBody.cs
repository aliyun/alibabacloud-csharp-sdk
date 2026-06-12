// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class LaunchServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the service publishing action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PublishNewVersion: A new version is published.</para>
        /// </description></item>
        /// <item><description><para>PublishOfflineVersion: An unpublished version is republished.</para>
        /// </description></item>
        /// <item><description><para>UpdateLatestVersion: The latest online version is updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PublishNewVersion</para>
        /// </summary>
        [NameInMap("ServiceLaunchResultType")]
        [Validation(Required=false)]
        public string ServiceLaunchResultType { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
