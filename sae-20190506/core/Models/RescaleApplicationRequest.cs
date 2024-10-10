// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RescaleApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically enable an auto scaling policy for the application. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: turns on Logon-free Sharing</description></item>
        /// <item><description><b>false</b>: turns off Logon-free Sharing</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum number of available instances. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>-1</b>, the minimum number of available instances is not determined based on this parameter. Default value: -1.</description></item>
        /// <item><description>If you set the value to a number <b>from 0 to 100</b>, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if the percentage is set to <b>50</b>% and five instances are available, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and <b>MinReadyInstanceRatio</b> is set to a number from 0 to 100, the value of MinReadyInstanceRatio** takes precedence.**** For example, if <b>MinReadyInstances</b> is set to **5, and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × <b>50%</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Special values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>0</b>, business interruptions occur when the application is updated.</description></item>
        /// <item><description>If you set the value to \<em>\</em>-1\<em>\</em>, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>The expected number of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
