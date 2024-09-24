// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttachRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of automatically connecting applications on the ECS instance to the application protection feature.</para>
        /// </summary>
        [NameInMap("AccessList")]
        [Validation(Required=false)]
        public List<DescribeAttachRecordsResponseBodyAccessList> AccessList { get; set; }
        public class DescribeAttachRecordsResponseBodyAccessList : TeaModel {
            /// <summary>
            /// <para>The status of connecting applications on the ECS instance to the application protection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: All applications are connected to the application protection feature.</description></item>
            /// <item><description><b>1</b>: Partial applications are connected to the application protection feature.</description></item>
            /// <item><description><b>2</b>: Applications failed to be connected to the application protection feature.</description></item>
            /// <item><description><b>3</b>: Applications are being connected to the application protection feature.</description></item>
            /// <item><description><b>4</b>: Applications are not connected to the application protection feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachState")]
            [Validation(Required=false)]
            public long? AttachState { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic protection is enabled for the applications on the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b>: Automatic protection is enabled for the applications on the ECS instance.</description></item>
            /// <item><description><b>OFF</b>: Automatic protection is disabled for the applications on the ECS instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("AttachSwitch")]
            [Validation(Required=false)]
            public string AttachSwitch { get; set; }

            /// <summary>
            /// <para>The UUID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd405430-c027-4937-8398-10152dac****</para>
            /// </summary>
            [NameInMap("EcsUUID")]
            [Validation(Required=false)]
            public string EcsUUID { get; set; }

            /// <summary>
            /// <para>The message that shows the results of installing the RASP agent on the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("InstallMsg")]
            [Validation(Required=false)]
            public string InstallMsg { get; set; }

            /// <summary>
            /// <para>The status of installing the RASP agent on the ECS instance to enable automatic application connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: installed</description></item>
            /// <item><description><b>1</b>: installing</description></item>
            /// <item><description><b>2</b>: installation failed</description></item>
            /// <item><description><b>3</b>: installation timeout</description></item>
            /// <item><description><b>4</b>: uninstalled</description></item>
            /// <item><description><b>5</b>: uninstalling</description></item>
            /// <item><description><b>6</b>: uninstallation failed</description></item>
            /// <item><description><b>7</b>: uninstallation timeout</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstallState")]
            [Validation(Required=false)]
            public long? InstallState { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4E6157-9600-5588-86B9-38F09067****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
