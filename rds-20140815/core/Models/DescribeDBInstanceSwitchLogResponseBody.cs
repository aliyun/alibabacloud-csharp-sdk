// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSwitchLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rdsaiiabnaiiabn</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceSwitchLogResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceSwitchLogResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceSwitchLogResponseBodyItemsItem> Item { get; set; }
            public class DescribeDBInstanceSwitchLogResponseBodyItemsItem : TeaModel {
                [NameInMap("AffectedSessions")]
                [Validation(Required=false)]
                public string AffectedSessions { get; set; }

                [NameInMap("HAStatus")]
                [Validation(Required=false)]
                public string HAStatus { get; set; }

                [NameInMap("SwitchCauseCode")]
                [Validation(Required=false)]
                public string SwitchCauseCode { get; set; }

                [NameInMap("SwitchCauseDetail")]
                [Validation(Required=false)]
                public string SwitchCauseDetail { get; set; }

                [NameInMap("SwitchFinishTime")]
                [Validation(Required=false)]
                public string SwitchFinishTime { get; set; }

                [NameInMap("SwitchId")]
                [Validation(Required=false)]
                public string SwitchId { get; set; }

                [NameInMap("SwitchStartTime")]
                [Validation(Required=false)]
                public string SwitchStartTime { get; set; }

                [NameInMap("TotalSessions")]
                [Validation(Required=false)]
                public string TotalSessions { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D1CA494F-CC13-4EB6-8C4D-5352EE4045BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
