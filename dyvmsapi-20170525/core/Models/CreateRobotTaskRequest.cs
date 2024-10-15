// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CreateRobotTaskRequest : TeaModel {
        /// <summary>
        /// <para>The calling number.</para>
        /// <para>You must use the phone numbers that you have purchased and separate multiple numbers with commas (,). You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Real Number Service</b> &gt; <b>Real Number Management</b> to view the numbers you purchased.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****5678</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The company name, which must be the same as the <b>enterprise name</b> on the qualification management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The ID of the robot or communication script that is used to initiate the call.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Intelligent Voice Robot</b> &gt; <b>Communication Script Management</b> to view the communication script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000023****</para>
        /// </summary>
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        /// <summary>
        /// <para>Specifies whether to call the self-managed line. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>true</b>, calling numbers are not verified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSelfLine")]
        [Validation(Required=false)]
        public bool? IsSelfLine { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable number status identification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>true</b>, the reason why a call is not answered is recorded.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NumberStatusIdent")]
        [Validation(Required=false)]
        public bool? NumberStatusIdent { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The redial interval. Unit: minutes. The value must be greater than 1.</para>
        /// <remarks>
        /// <para>The maximum redial interval is 30 minutes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RecallInterval")]
        [Validation(Required=false)]
        public int? RecallInterval { get; set; }

        /// <summary>
        /// <para>The call state in which redial is required. Separate multiple call states with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200010</b>: The phone of the called party is powered off.</description></item>
        /// <item><description><b>200011</b>: The number of the called party is out of service.</description></item>
        /// <item><description><b>200002</b>: The line is busy.</description></item>
        /// <item><description><b>200012</b>: The call is lost.</description></item>
        /// <item><description><b>200005</b>: The called party cannot be connected.</description></item>
        /// <item><description><b>200003</b>: The called party does not respond to the call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200010,200011</para>
        /// </summary>
        [NameInMap("RecallStateCodes")]
        [Validation(Required=false)]
        public string RecallStateCodes { get; set; }

        /// <summary>
        /// <para>The number of redial times.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecallTimes")]
        [Validation(Required=false)]
        public int? RecallTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-redial. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables auto-redial.</description></item>
        /// <item><description><b>0</b>: disables auto-redial.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryType")]
        [Validation(Required=false)]
        public int? RetryType { get; set; }

        /// <summary>
        /// <para>The task name. The task name can be up to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Template</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
