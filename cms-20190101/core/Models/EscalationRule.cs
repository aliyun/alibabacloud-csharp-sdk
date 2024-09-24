// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EscalationRule : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public List<EscalationRuleEscalations> Escalations { get; set; }
        public class EscalationRuleEscalations : TeaModel {
            [NameInMap("BackupContactGroups")]
            [Validation(Required=false)]
            public List<string> BackupContactGroups { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            [NameInMap("ContactGroupsByLevel")]
            [Validation(Required=false)]
            public EscalationRuleEscalationsContactGroupsByLevel ContactGroupsByLevel { get; set; }
            public class EscalationRuleEscalationsContactGroupsByLevel : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public List<string> Critical { get; set; }

                [NameInMap("Error")]
                [Validation(Required=false)]
                public List<string> Error { get; set; }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public List<string> Info { get; set; }

                [NameInMap("Resolve")]
                [Validation(Required=false)]
                public List<string> Resolve { get; set; }

                [NameInMap("Warning")]
                [Validation(Required=false)]
                public List<string> Warning { get; set; }

            }

            [NameInMap("EscalateMin")]
            [Validation(Required=false)]
            public long? EscalateMin { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
