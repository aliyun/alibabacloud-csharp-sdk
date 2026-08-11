// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpSyncConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic synchronization is enabled.</para>
        /// </summary>
        [NameInMap("AutoSyncEnabled")]
        [Validation(Required=false)]
        public bool? AutoSyncEnabled { get; set; }

        /// <summary>
        /// <para>The names of the departments selected for synchronization. The names have a one-to-one relationship with IdpDepartmentIds.</para>
        /// </summary>
        [NameInMap("IdpDepartmentInfos")]
        [Validation(Required=false)]
        public List<IdpSyncConfigIdpDepartmentInfos> IdpDepartmentInfos { get; set; }
        public class IdpSyncConfigIdpDepartmentInfos : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The scheduled synchronization interval, in seconds.</para>
        /// </summary>
        [NameInMap("ScheduleSyncIntervalSecond")]
        [Validation(Required=false)]
        public long? ScheduleSyncIntervalSecond { get; set; }

        [NameInMap("UserSyncEnabled")]
        [Validation(Required=false)]
        public bool? UserSyncEnabled { get; set; }

    }

}
