// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AttachApplicationPolarFSRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LT**********************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeyId")]
        [Validation(Required=false)]
        public string PolarFSAccessKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>H3****************************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeySecret")]
        [Validation(Required=false)]
        public string PolarFSAccessKeySecret { get; set; }

        /// <summary>
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
