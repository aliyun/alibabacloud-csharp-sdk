// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class RecoverClusterRequest : TeaModel {
        /// <summary>
        /// <para>The service type of the domain account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>nis</description></item>
        /// <item><description>ldap</description></item>
        /// </list>
        /// <para>Default value: nis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nis</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The version of the E-HPC client. The default value is the latest version of the client.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87223.html">ListCurrentClientVersion</a> operation to query the latest version of the E-HPC client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.76</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The cluster ID. The cluster must be in the Exception state.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the ID and status of a cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> and <a href="https://help.aliyun.com/document_detail/87215.html">ListCustomImages</a> operations to query the images that are supported by E-HPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp18133n0335yq****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public image</description></item>
        /// <item><description>self: custom image</description></item>
        /// <item><description>others: shared image</description></item>
        /// </list>
        /// <para>Default value: system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The tag of the system image.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> and <a href="https://help.aliyun.com/document_detail/87215.html">ListCustomImages</a> operations to query the image tags supported by Elastic High Performance Computing (E-HPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// <para>The type of the scheduler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pbs</description></item>
        /// <item><description>slurm</description></item>
        /// <item><description>opengridscheduler</description></item>
        /// <item><description>deadline</description></item>
        /// </list>
        /// <para>Default value: pbs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pbs</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

    }

}
