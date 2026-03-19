// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstanceList InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstanceListInstance : TeaModel {
                [NameInMap("DataLinkName")]
                [Validation(Required=false)]
                public string DataLinkName { get; set; }

                [NameInMap("DatabasePassword")]
                [Validation(Required=false)]
                public string DatabasePassword { get; set; }

                [NameInMap("DatabaseUser")]
                [Validation(Required=false)]
                public string DatabaseUser { get; set; }

                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                [NameInMap("DbaNickName")]
                [Validation(Required=false)]
                public string DbaNickName { get; set; }

                [NameInMap("DdlOnline")]
                [Validation(Required=false)]
                public int? DdlOnline { get; set; }

                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                [NameInMap("EcsRegion")]
                [Validation(Required=false)]
                public string EcsRegion { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("ExportTimeout")]
                [Validation(Required=false)]
                public int? ExportTimeout { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("InstanceAlias")]
                [Validation(Required=false)]
                public string InstanceAlias { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerIdList OwnerIdList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerNameList OwnerNameList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("QueryTimeout")]
                [Validation(Required=false)]
                public int? QueryTimeout { get; set; }

                [NameInMap("SafeRuleId")]
                [Validation(Required=false)]
                public string SafeRuleId { get; set; }

                [NameInMap("SellSitd")]
                [Validation(Required=false)]
                public bool? SellSitd { get; set; }

                [NameInMap("SellTrust")]
                [Validation(Required=false)]
                public string SellTrust { get; set; }

                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                [NameInMap("StandardGroup")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceStandardGroup StandardGroup { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceStandardGroup : TeaModel {
                    [NameInMap("GroupMode")]
                    [Validation(Required=false)]
                    public string GroupMode { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("UseDsql")]
                [Validation(Required=false)]
                public int? UseDsql { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B07137-F6AE-4756-8474-7F92BB6C4E04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of database instances that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
