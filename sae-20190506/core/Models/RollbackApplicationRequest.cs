// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
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
        public string AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// <para>The wait time between batches. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum number of available instances. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>-1</b>, the minimum number of available instances is not determined based on this parameter. Default value: -1.</description></item>
        /// <item><description>If you set the value to a number <b>from 0 to 100</b>, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if the percentage is set to <b>50</b>% and five instances are available, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When both <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and <b>MinReadyInstanceRatio</b> is set to a number from 0 to 100, the value of <b>MinReadyInstanceRatio</b> takes precedence.** For example, if <b>MinReadyInstances</b> is set to **5, and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × <b>50%</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Take note of the following rules:</para>
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
        /// <para>The deployment policy. If the minimum number of available instances is 1, the value of the <b>UpdateStrategy</b> parameter is an empty string (&quot;&quot;). If the minimum number of available instances is larger than 1, specify this parameter based on your requirements. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Perform canary release for one instance and release the remaining instances in two batches automatically with a one-minute interval between the deployment of each instance:</para>
        /// <para><c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Perform canary release for one instance and release the remaining instances in two batches manually:</para>
        /// <para><c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Release the instances in two batches automatically with no interval between the deployment of each instance:</para>
        /// <para><c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
        /// </description></item>
        /// </list>
        /// <para>The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the release policy. Valid values: <b>GrayBatchUpdate</b> and <b>BatchUpdate</b>.</para>
        /// </description></item>
        /// <item><description><para><b>batchUpdate</b>: the phased release policy.</para>
        /// <list type="bullet">
        /// <item><description><b>batch</b>: the number of release batches.</description></item>
        /// <item><description><b>releaseType</b>: the processing method for the batches. Valid values: <b>auto</b> and <b>manual</b>.</description></item>
        /// <item><description><b>batchWaitTime</b>: the interval between release batches. Unit: seconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>grayUpdate</b>: the number of release batches in the phased release after a canary release. This parameter is returned only if the <b>type</b> parameter is set to <b>GrayBatchUpdate</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</para>
        /// </summary>
        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the application version. Call the <a href="https://help.aliyun.com/document_detail/162054.html">ListAppVersions</a> operation to obtain the version ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0026ff7f-2b57-4127-bdd0-9bf202bb9****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
