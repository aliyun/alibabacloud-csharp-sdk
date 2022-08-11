// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterRequest : TeaModel {
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestTags> Tags { get; set; }
        public class ScaleClusterRequestTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestTaints> Taints { get; set; }
        public class ScaleClusterRequestTaints : TeaModel {
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        [NameInMap("worker_data_disk")]
        [Validation(Required=false)]
        public bool? WorkerDataDisk { get; set; }

        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleClusterRequestWorkerDataDisks : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

    }

}
