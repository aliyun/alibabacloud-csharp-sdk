// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyEngineMigrationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;pc-bp1m9tt23o5kh834y.rwlb.rds.aliyuncs.com\&quot;:\&quot;rm-bp1ycl5o6ojs957o0.mysql.rds.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionStrings")]
        [Validation(Required=false)]
        public string ConnectionStrings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pxc-htri0****r4k9p</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>newmaster789</para>
        /// </summary>
        [NameInMap("NewMasterDBInstanceName")]
        [Validation(Required=false)]
        public string NewMasterDBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>source456</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SwapConnectionString")]
        [Validation(Required=false)]
        public string SwapConnectionString { get; set; }

    }

}
