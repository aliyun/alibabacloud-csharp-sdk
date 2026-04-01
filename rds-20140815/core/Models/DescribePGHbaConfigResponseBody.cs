// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePGHbaConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DefaultHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyDefaultHbaItems DefaultHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyDefaultHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the previous modification was made to the pg_hba.conf file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-25T06:00:40Z</para>
        /// </summary>
        [NameInMap("HbaModifyTime")]
        [Validation(Required=false)]
        public string HbaModifyTime { get; set; }

        /// <summary>
        /// <para>The status of the previous modification to the pg_hba.conf file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>setting</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// <para>The reason why the previous modification was made to the pg_hba.conf file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified users (testuser) is not exist.</para>
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A147A124-A147-5CCF-9609-B73C028848DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyRunningHbaItems RunningHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyRunningHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

    }

}
