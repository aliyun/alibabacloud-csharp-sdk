// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The UTC time when the backup ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupEndTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupEndTimeUTC { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday: performs backup every Monday.</description></item>
        /// <item><description>Tuesday: performs backup every Tuesday.</description></item>
        /// <item><description>Wednesday: performs backup every Wednesday.</description></item>
        /// <item><description>Thursday: performs backup every Thursday.</description></item>
        /// <item><description>Friday: performs backup every Friday.</description></item>
        /// <item><description>Saturday: performs backup every Saturday.</description></item>
        /// <item><description>Sunday: performs backup every Sunday.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thursday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The UTC time when the backup starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupStartTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupStartTimeUTC { get; set; }

        /// <summary>
        /// <para>The backup time range in the current time zone. The interval is 1 hour.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:00-02:00</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

    }

}
