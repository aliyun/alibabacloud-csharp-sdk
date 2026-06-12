// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateScheduledSQLRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ScheduledSQLConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Update scheduled SQL task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-scheduled-sql</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The scheduling configuration of the task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
