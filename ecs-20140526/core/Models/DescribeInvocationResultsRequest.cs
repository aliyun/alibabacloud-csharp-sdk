// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsRequest : TeaModel {
        /// <summary>
        /// <para>$.parameters[11].schema.example</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <DescribeInvocationResultsResponse>
        ///     <RequestId>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</RequestId>
        ///     <Invocation>
        ///         <InvocationResults>
        ///             <InvocationResult>
        ///                 <Dropped>0</Dropped>
        ///                 <InvocationStatus>Success</InvocationStatus>
        ///                 <InstanceId>i-bp1i7gg30r52z2em****</InstanceId>
        ///                 <ExitCode>0</ExitCode>
        ///                 <ErrorInfo>the specified instance does not exists</ErrorInfo>
        ///                 <StartTime>2019-12-20T06:15:55Z</StartTime>
        ///                 <Repeats>0</Repeats>
        ///                 <InvokeRecordStatus>Running</InvokeRecordStatus>
        ///                 <FinishedTime>2019-12-20T06:15:56Z</FinishedTime>
        ///                 <Output>MTU6MzA6MDEK</Output>
        ///                 <CommandId>c-hz0jdfwcsr****</CommandId>
        ///                 <ErrorCode>InstanceNotExists</ErrorCode>
        ///                 <InvokeId>t-hz0jdfwd9f****</InvokeId>
        ///                 <StopTime>2020-01-19T09:15:47Z</StopTime>
        ///                 <ContainerId>ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****</ContainerId>
        ///                 <ContainerName>test-container</ContainerName>
        ///                 <Tags>
        ///                     <TagKey>owner</TagKey>
        ///                     <TagValue>zhangsan</TagValue>
        ///                 </Tags>
        ///             </InvocationResult>
        ///         </InvocationResults>
        ///         <TotalCount>1</TotalCount>
        ///         <PageSize>1</PageSize>
        ///         <PageNumber>1</PageNumber>
        ///     </Invocation>
        /// </DescribeInvocationResultsResponse>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>{
        ///   &quot;RequestId&quot; : &quot;473469C7-AA6F-4DC5-B3DB-A3DC0DE*****&quot;,
        ///   &quot;Invocation&quot; : {
        ///     &quot;InvocationResults&quot; : {
        ///       &quot;InvocationResult&quot; : [ {
        ///         &quot;Dropped&quot; : 0,
        ///         &quot;InvocationStatus&quot; : &quot;Success&quot;,
        ///         &quot;InstanceId&quot; : &quot;i-bp1i7gg30r52z2em****&quot;,
        ///         &quot;ExitCode&quot; : 0,
        ///         &quot;ErrorInfo&quot; : &quot;the specified instance does not exists&quot;,
        ///         &quot;StartTime&quot; : &quot;2019-12-20T06:15:55Z&quot;,
        ///         &quot;Repeats&quot; : 0,
        ///         &quot;InvokeRecordStatus&quot; : &quot;Running&quot;,
        ///         &quot;FinishedTime&quot; : &quot;2019-12-20T06:15:56Z&quot;,
        ///         &quot;Output&quot; : &quot;MTU6MzA6MDEK&quot;,
        ///         &quot;CommandId&quot; : &quot;c-hz0jdfwcsr****&quot;,
        ///         &quot;ErrorCode&quot; : &quot;InstanceNotExists&quot;,
        ///         &quot;InvokeId&quot; : &quot;t-hz0jdfwd9f****&quot;,
        ///         &quot;StopTime&quot; : &quot;2020-01-19T09:15:47Z&quot;,
        ///         &quot;ContainerId&quot;:&quot;ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****&quot;,
        ///         &quot;ContainerName&quot;:&quot;test-container&quot;,<br>        &quot;Tags&quot;: [
        ///                     {
        ///                         &quot;TagKey&quot;: &quot;owner&quot;,
        ///                         &quot;TagValue&quot;: &quot;zhangsan&quot;
        ///                     }
        ///                 ]
        ///       } ]
        ///     },
        ///     &quot;TotalCount&quot; : 1,
        ///     &quot;PageSize&quot; : 1,
        ///     &quot;PageNumber&quot; : 1
        ///   }
        /// }</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeHistory")]
        [Validation(Required=false)]
        public bool? IncludeHistory { get; set; }

        /// <summary>
        /// <para>$.parameters[11].schema.description</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i7gg30r52z2em****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>$.parameters[11].schema.items.enumValueTitles</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>$.parameters[11].schema.enumValueTitles</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

        /// <summary>
        /// <para>FEATUREecsXZ3H4M</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>dubbo</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>acs:ecs:{#regionId}:{#accountId}:command/*</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>acs:ecs:{#regionId}:{#accountId}:instance/*</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>$.parameters[11].schema.items.description</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>$.parameters[11].schema.items.example</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the command. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The ID of the command task. You can call the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> operation to query the IDs of all command tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
