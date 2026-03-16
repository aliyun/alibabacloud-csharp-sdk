// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class SwitchGdnMemberRoleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DstMainConnectString")]
        [Validation(Required=false)]
        public string DstMainConnectString { get; set; }

        [NameInMap("DstMainPort")]
        [Validation(Required=false)]
        public string DstMainPort { get; set; }

        [NameInMap("IsModifyEndpoint")]
        [Validation(Required=false)]
        public string IsModifyEndpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SrcMainConnectString")]
        [Validation(Required=false)]
        public string SrcMainConnectString { get; set; }

        [NameInMap("SrcMainPort")]
        [Validation(Required=false)]
        public string SrcMainPort { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

        [NameInMap("TaskTimeout")]
        [Validation(Required=false)]
        public long? TaskTimeout { get; set; }

    }

}
