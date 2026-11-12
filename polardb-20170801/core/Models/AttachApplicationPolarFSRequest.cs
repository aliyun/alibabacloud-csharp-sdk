// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AttachApplicationPolarFSRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The AccessKey ID of the Alibaba Cloud account or RAM user. Ensure that the account or RAM user is authorized when you create the Polarlakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LT**********************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeyId")]
        [Validation(Required=false)]
        public string PolarFSAccessKeyId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret of the Alibaba Cloud account or RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H3****************************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeySecret")]
        [Validation(Required=false)]
        public string PolarFSAccessKeySecret { get; set; }

        /// <summary>
        /// <para>The instance ID of the Polarlakebase cold storage instance.</para>
        /// <para>Currently, only the following applications support cold storage instances:</para>
        /// <list type="bullet">
        /// <item><description>supabase</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-**************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

    }

}
