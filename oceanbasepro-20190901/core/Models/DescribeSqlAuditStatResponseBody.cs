// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSqlAuditStatResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSqlAuditStatResponseBodyData> Data { get; set; }
        public class DescribeSqlAuditStatResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public double? AffectRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_database_1</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>142</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public double? ExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public double? ReturnRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public double? ScanRows { get; set; }

            /// <summary>
            /// <para>Sql ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UPDATE <c>oceanbase_test_table</c> SET <c>name</c> = ? WHERE <c>key</c> = ?</para>
            /// </summary>
            [NameInMap("SqlStatement")]
            [Validation(Required=false)]
            public string SqlStatement { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t33h8y08k****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalAffectRows")]
            [Validation(Required=false)]
            public long? TotalAffectRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalFailed")]
            [Validation(Required=false)]
            public long? TotalFailed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalReturnRows")]
            [Validation(Required=false)]
            public long? TotalReturnRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalScanRows")]
            [Validation(Required=false)]
            public long? TotalScanRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSucceed")]
            [Validation(Required=false)]
            public long? TotalSucceed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx.xx.xx.xx</para>
            /// </summary>
            [NameInMap("UserClientIp")]
            [Validation(Required=false)]
            public string UserClientIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_mysql</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
