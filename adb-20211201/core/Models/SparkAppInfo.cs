// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAppInfo : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s202207151211hz0c****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the Spark application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SparkTest</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The database ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-23xxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The information about the Spark application.</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Detail Detail { get; set; }

        /// <summary>
        /// <para>The alert message returned, such as task execution failure or insufficient resources. If no alert occurs, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WARN: Disk is full.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The priority of the Spark application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The state of the Spark application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SUBMITTED</b></description></item>
        /// <item><description><b>STARTING</b></description></item>
        /// <item><description><b>RUNNING</b></description></item>
        /// <item><description><b>FAILING</b></description></item>
        /// <item><description><b>FAILED</b></description></item>
        /// <item><description><b>KILLING</b></description></item>
        /// <item><description><b>KILLED</b></description></item>
        /// <item><description><b>SUCCEEDING</b></description></item>
        /// <item><description><b>COMPLETED</b></description></item>
        /// <item><description><b>FATAL</b></description></item>
        /// <item><description><b>UNKNOWN</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUBMITTED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
