// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("resourcedirectorymaster", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /**
         * @summary Accepts an invitation.
         *
         * @description After an invited Alibaba Cloud account joins a resource directory, it becomes a member of the resource directory. By default, the name of the invited Alibaba Cloud account is used as the display name of the account in the resource directory.
         *
         * @param request AcceptHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptHandshakeResponse
         */
        public AcceptHandshakeResponse AcceptHandshakeWithOptions(AcceptHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptHandshakeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Accepts an invitation.
         *
         * @description After an invited Alibaba Cloud account joins a resource directory, it becomes a member of the resource directory. By default, the name of the invited Alibaba Cloud account is used as the display name of the account in the resource directory.
         *
         * @param request AcceptHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptHandshakeResponse
         */
        public async Task<AcceptHandshakeResponse> AcceptHandshakeWithOptionsAsync(AcceptHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptHandshakeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Accepts an invitation.
         *
         * @description After an invited Alibaba Cloud account joins a resource directory, it becomes a member of the resource directory. By default, the name of the invited Alibaba Cloud account is used as the display name of the account in the resource directory.
         *
         * @param request AcceptHandshakeRequest
         * @return AcceptHandshakeResponse
         */
        public AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptHandshakeWithOptions(request, runtime);
        }

        /**
         * @summary Accepts an invitation.
         *
         * @description After an invited Alibaba Cloud account joins a resource directory, it becomes a member of the resource directory. By default, the name of the invited Alibaba Cloud account is used as the display name of the account in the resource directory.
         *
         * @param request AcceptHandshakeRequest
         * @return AcceptHandshakeResponse
         */
        public async Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptHandshakeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a contact.
         *
         * @param request AddMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMessageContactResponse
         */
        public AddMessageContactResponse AddMessageContactWithOptions(AddMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypes))
            {
                query["MessageTypes"] = request.MessageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a contact.
         *
         * @param request AddMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMessageContactResponse
         */
        public async Task<AddMessageContactResponse> AddMessageContactWithOptionsAsync(AddMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypes))
            {
                query["MessageTypes"] = request.MessageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a contact.
         *
         * @param request AddMessageContactRequest
         * @return AddMessageContactResponse
         */
        public AddMessageContactResponse AddMessageContact(AddMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Adds a contact.
         *
         * @param request AddMessageContactRequest
         * @return AddMessageContactResponse
         */
        public async Task<AddMessageContactResponse> AddMessageContactAsync(AddMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMessageContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Binds a contact to a resource directory, folder, or member.
         *
         * @param request AssociateMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssociateMembersResponse
         */
        public AssociateMembersResponse AssociateMembersWithOptions(AssociateMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateMembers",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Binds a contact to a resource directory, folder, or member.
         *
         * @param request AssociateMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssociateMembersResponse
         */
        public async Task<AssociateMembersResponse> AssociateMembersWithOptionsAsync(AssociateMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateMembers",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Binds a contact to a resource directory, folder, or member.
         *
         * @param request AssociateMembersRequest
         * @return AssociateMembersResponse
         */
        public AssociateMembersResponse AssociateMembers(AssociateMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateMembersWithOptions(request, runtime);
        }

        /**
         * @summary Binds a contact to a resource directory, folder, or member.
         *
         * @param request AssociateMembersRequest
         * @return AssociateMembersResponse
         */
        public async Task<AssociateMembersResponse> AssociateMembersAsync(AssociateMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches an access control policy.
         *
         * @description After you attach a custom access control policy, the operations performed on resources by using members are limited by the policy. Make sure that the attached policy meets your expectations. Otherwise, your business may be affected.
         * By default, the system access control policy FullAliyunAccess is attached to each folder and member.
         * The access control policy that is attached to a folder also applies to all its subfolders and all members in the subfolders.
         * A maximum of 10 access control policies can be attached to a folder or member.
         *
         * @param request AttachControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachControlPolicyResponse
         */
        public AttachControlPolicyResponse AttachControlPolicyWithOptions(AttachControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches an access control policy.
         *
         * @description After you attach a custom access control policy, the operations performed on resources by using members are limited by the policy. Make sure that the attached policy meets your expectations. Otherwise, your business may be affected.
         * By default, the system access control policy FullAliyunAccess is attached to each folder and member.
         * The access control policy that is attached to a folder also applies to all its subfolders and all members in the subfolders.
         * A maximum of 10 access control policies can be attached to a folder or member.
         *
         * @param request AttachControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachControlPolicyResponse
         */
        public async Task<AttachControlPolicyResponse> AttachControlPolicyWithOptionsAsync(AttachControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches an access control policy.
         *
         * @description After you attach a custom access control policy, the operations performed on resources by using members are limited by the policy. Make sure that the attached policy meets your expectations. Otherwise, your business may be affected.
         * By default, the system access control policy FullAliyunAccess is attached to each folder and member.
         * The access control policy that is attached to a folder also applies to all its subfolders and all members in the subfolders.
         * A maximum of 10 access control policies can be attached to a folder or member.
         *
         * @param request AttachControlPolicyRequest
         * @return AttachControlPolicyResponse
         */
        public AttachControlPolicyResponse AttachControlPolicy(AttachControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Attaches an access control policy.
         *
         * @description After you attach a custom access control policy, the operations performed on resources by using members are limited by the policy. Make sure that the attached policy meets your expectations. Otherwise, your business may be affected.
         * By default, the system access control policy FullAliyunAccess is attached to each folder and member.
         * The access control policy that is attached to a folder also applies to all its subfolders and all members in the subfolders.
         * A maximum of 10 access control policies can be attached to a folder or member.
         *
         * @param request AttachControlPolicyRequest
         * @return AttachControlPolicyResponse
         */
        public async Task<AttachControlPolicyResponse> AttachControlPolicyAsync(AttachControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Binds a mobile phone number to a member of the resource account type in a resource directory for security purposes.
         *
         * @description You can call this API operation only to bind a mobile phone number to a member of the resource account type. You cannot call this API operation to change the mobile phone number that is bound to a member of the resource account type.
         * To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request BindSecureMobilePhoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSecureMobilePhoneResponse
         */
        public BindSecureMobilePhoneResponse BindSecureMobilePhoneWithOptions(BindSecureMobilePhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSecureMobilePhone",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSecureMobilePhoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Binds a mobile phone number to a member of the resource account type in a resource directory for security purposes.
         *
         * @description You can call this API operation only to bind a mobile phone number to a member of the resource account type. You cannot call this API operation to change the mobile phone number that is bound to a member of the resource account type.
         * To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request BindSecureMobilePhoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSecureMobilePhoneResponse
         */
        public async Task<BindSecureMobilePhoneResponse> BindSecureMobilePhoneWithOptionsAsync(BindSecureMobilePhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSecureMobilePhone",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSecureMobilePhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Binds a mobile phone number to a member of the resource account type in a resource directory for security purposes.
         *
         * @description You can call this API operation only to bind a mobile phone number to a member of the resource account type. You cannot call this API operation to change the mobile phone number that is bound to a member of the resource account type.
         * To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request BindSecureMobilePhoneRequest
         * @return BindSecureMobilePhoneResponse
         */
        public BindSecureMobilePhoneResponse BindSecureMobilePhone(BindSecureMobilePhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindSecureMobilePhoneWithOptions(request, runtime);
        }

        /**
         * @summary Binds a mobile phone number to a member of the resource account type in a resource directory for security purposes.
         *
         * @description You can call this API operation only to bind a mobile phone number to a member of the resource account type. You cannot call this API operation to change the mobile phone number that is bound to a member of the resource account type.
         * To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request BindSecureMobilePhoneRequest
         * @return BindSecureMobilePhoneResponse
         */
        public async Task<BindSecureMobilePhoneResponse> BindSecureMobilePhoneAsync(BindSecureMobilePhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindSecureMobilePhoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels the email address change of a member.
         *
         * @param request CancelChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelChangeAccountEmailResponse
         */
        public CancelChangeAccountEmailResponse CancelChangeAccountEmailWithOptions(CancelChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelChangeAccountEmailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels the email address change of a member.
         *
         * @param request CancelChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelChangeAccountEmailResponse
         */
        public async Task<CancelChangeAccountEmailResponse> CancelChangeAccountEmailWithOptionsAsync(CancelChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelChangeAccountEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the email address change of a member.
         *
         * @param request CancelChangeAccountEmailRequest
         * @return CancelChangeAccountEmailResponse
         */
        public CancelChangeAccountEmailResponse CancelChangeAccountEmail(CancelChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelChangeAccountEmailWithOptions(request, runtime);
        }

        /**
         * @summary Cancels the email address change of a member.
         *
         * @param request CancelChangeAccountEmailRequest
         * @return CancelChangeAccountEmailResponse
         */
        public async Task<CancelChangeAccountEmailResponse> CancelChangeAccountEmailAsync(CancelChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelChangeAccountEmailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels an invitation.
         *
         * @param request CancelHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelHandshakeResponse
         */
        public CancelHandshakeResponse CancelHandshakeWithOptions(CancelHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelHandshakeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels an invitation.
         *
         * @param request CancelHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelHandshakeResponse
         */
        public async Task<CancelHandshakeResponse> CancelHandshakeWithOptionsAsync(CancelHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelHandshakeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels an invitation.
         *
         * @param request CancelHandshakeRequest
         * @return CancelHandshakeResponse
         */
        public CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelHandshakeWithOptions(request, runtime);
        }

        /**
         * @summary Cancels an invitation.
         *
         * @param request CancelHandshakeRequest
         * @return CancelHandshakeResponse
         */
        public async Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelHandshakeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels the update of the mobile phone number or email address of a contact.
         *
         * @param request CancelMessageContactUpdateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelMessageContactUpdateResponse
         */
        public CancelMessageContactUpdateResponse CancelMessageContactUpdateWithOptions(CancelMessageContactUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelMessageContactUpdate",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelMessageContactUpdateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels the update of the mobile phone number or email address of a contact.
         *
         * @param request CancelMessageContactUpdateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelMessageContactUpdateResponse
         */
        public async Task<CancelMessageContactUpdateResponse> CancelMessageContactUpdateWithOptionsAsync(CancelMessageContactUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelMessageContactUpdate",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelMessageContactUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the update of the mobile phone number or email address of a contact.
         *
         * @param request CancelMessageContactUpdateRequest
         * @return CancelMessageContactUpdateResponse
         */
        public CancelMessageContactUpdateResponse CancelMessageContactUpdate(CancelMessageContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelMessageContactUpdateWithOptions(request, runtime);
        }

        /**
         * @summary Cancels the update of the mobile phone number or email address of a contact.
         *
         * @param request CancelMessageContactUpdateRequest
         * @return CancelMessageContactUpdateResponse
         */
        public async Task<CancelMessageContactUpdateResponse> CancelMessageContactUpdateAsync(CancelMessageContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelMessageContactUpdateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the email address that is bound to a member.
         *
         * @param request ChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeAccountEmailResponse
         */
        public ChangeAccountEmailResponse ChangeAccountEmailWithOptions(ChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAccountEmailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the email address that is bound to a member.
         *
         * @param request ChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeAccountEmailResponse
         */
        public async Task<ChangeAccountEmailResponse> ChangeAccountEmailWithOptionsAsync(ChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAccountEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the email address that is bound to a member.
         *
         * @param request ChangeAccountEmailRequest
         * @return ChangeAccountEmailResponse
         */
        public ChangeAccountEmailResponse ChangeAccountEmail(ChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAccountEmailWithOptions(request, runtime);
        }

        /**
         * @summary Changes the email address that is bound to a member.
         *
         * @param request ChangeAccountEmailRequest
         * @return ChangeAccountEmailResponse
         */
        public async Task<ChangeAccountEmailResponse> ChangeAccountEmailAsync(ChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAccountEmailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Performs a member deletion check.
         *
         * @description Before you delete a member, you must call this API operation to check whether the member can be deleted.
         *
         * @param request CheckAccountDeleteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckAccountDeleteResponse
         */
        public CheckAccountDeleteResponse CheckAccountDeleteWithOptions(CheckAccountDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAccountDelete",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountDeleteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Performs a member deletion check.
         *
         * @description Before you delete a member, you must call this API operation to check whether the member can be deleted.
         *
         * @param request CheckAccountDeleteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckAccountDeleteResponse
         */
        public async Task<CheckAccountDeleteResponse> CheckAccountDeleteWithOptionsAsync(CheckAccountDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAccountDelete",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Performs a member deletion check.
         *
         * @description Before you delete a member, you must call this API operation to check whether the member can be deleted.
         *
         * @param request CheckAccountDeleteRequest
         * @return CheckAccountDeleteResponse
         */
        public CheckAccountDeleteResponse CheckAccountDelete(CheckAccountDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccountDeleteWithOptions(request, runtime);
        }

        /**
         * @summary Performs a member deletion check.
         *
         * @description Before you delete a member, you must call this API operation to check whether the member can be deleted.
         *
         * @param request CheckAccountDeleteRequest
         * @return CheckAccountDeleteResponse
         */
        public async Task<CheckAccountDeleteResponse> CheckAccountDeleteAsync(CheckAccountDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccountDeleteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a custom access control policy.
         *
         * @param request CreateControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateControlPolicyResponse
         */
        public CreateControlPolicyResponse CreateControlPolicyWithOptions(CreateControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectScope))
            {
                query["EffectScope"] = request.EffectScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a custom access control policy.
         *
         * @param request CreateControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateControlPolicyResponse
         */
        public async Task<CreateControlPolicyResponse> CreateControlPolicyWithOptionsAsync(CreateControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectScope))
            {
                query["EffectScope"] = request.EffectScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a custom access control policy.
         *
         * @param request CreateControlPolicyRequest
         * @return CreateControlPolicyResponse
         */
        public CreateControlPolicyResponse CreateControlPolicy(CreateControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a custom access control policy.
         *
         * @param request CreateControlPolicyRequest
         * @return CreateControlPolicyResponse
         */
        public async Task<CreateControlPolicyResponse> CreateControlPolicyAsync(CreateControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a folder.
         *
         * @description A maximum of five levels of folders can be created under the Root folder.
         *
         * @param request CreateFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolderWithOptions(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderName))
            {
                query["FolderName"] = request.FolderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a folder.
         *
         * @description A maximum of five levels of folders can be created under the Root folder.
         *
         * @param request CreateFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderName))
            {
                query["FolderName"] = request.FolderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a folder.
         *
         * @description A maximum of five levels of folders can be created under the Root folder.
         *
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFolderWithOptions(request, runtime);
        }

        /**
         * @summary Creates a folder.
         *
         * @description A maximum of five levels of folders can be created under the Root folder.
         *
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFolderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a member of the resource account type.
         *
         * @description A member serves as a container for resources and is also an organizational unit in a resource directory. A member indicates a project or application. The resources of different members are isolated.
         * This topic provides an example on how to call the API operation to create a member in the `fd-r23M55****` folder. The display name of the member is `Dev`, and the prefix for the Alibaba Cloud account name of the member is `alice`.
         *
         * @param request CreateResourceAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceAccountResponse
         */
        public CreateResourceAccountResponse CreateResourceAccountWithOptions(CreateResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNamePrefix))
            {
                query["AccountNamePrefix"] = request.AccountNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountId))
            {
                query["PayerAccountId"] = request.PayerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellAccountType))
            {
                query["ResellAccountType"] = request.ResellAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a member of the resource account type.
         *
         * @description A member serves as a container for resources and is also an organizational unit in a resource directory. A member indicates a project or application. The resources of different members are isolated.
         * This topic provides an example on how to call the API operation to create a member in the `fd-r23M55****` folder. The display name of the member is `Dev`, and the prefix for the Alibaba Cloud account name of the member is `alice`.
         *
         * @param request CreateResourceAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceAccountResponse
         */
        public async Task<CreateResourceAccountResponse> CreateResourceAccountWithOptionsAsync(CreateResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNamePrefix))
            {
                query["AccountNamePrefix"] = request.AccountNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountId))
            {
                query["PayerAccountId"] = request.PayerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellAccountType))
            {
                query["ResellAccountType"] = request.ResellAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a member of the resource account type.
         *
         * @description A member serves as a container for resources and is also an organizational unit in a resource directory. A member indicates a project or application. The resources of different members are isolated.
         * This topic provides an example on how to call the API operation to create a member in the `fd-r23M55****` folder. The display name of the member is `Dev`, and the prefix for the Alibaba Cloud account name of the member is `alice`.
         *
         * @param request CreateResourceAccountRequest
         * @return CreateResourceAccountResponse
         */
        public CreateResourceAccountResponse CreateResourceAccount(CreateResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceAccountWithOptions(request, runtime);
        }

        /**
         * @summary Creates a member of the resource account type.
         *
         * @description A member serves as a container for resources and is also an organizational unit in a resource directory. A member indicates a project or application. The resources of different members are isolated.
         * This topic provides an example on how to call the API operation to create a member in the `fd-r23M55****` folder. The display name of the member is `Dev`, and the prefix for the Alibaba Cloud account name of the member is `alice`.
         *
         * @param request CreateResourceAccountRequest
         * @return CreateResourceAccountResponse
         */
        public async Task<CreateResourceAccountResponse> CreateResourceAccountAsync(CreateResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Rejects an invitation.
         *
         * @param request DeclineHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeclineHandshakeResponse
         */
        public DeclineHandshakeResponse DeclineHandshakeWithOptions(DeclineHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeclineHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeclineHandshakeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Rejects an invitation.
         *
         * @param request DeclineHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeclineHandshakeResponse
         */
        public async Task<DeclineHandshakeResponse> DeclineHandshakeWithOptionsAsync(DeclineHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeclineHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeclineHandshakeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Rejects an invitation.
         *
         * @param request DeclineHandshakeRequest
         * @return DeclineHandshakeResponse
         */
        public DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeclineHandshakeWithOptions(request, runtime);
        }

        /**
         * @summary Rejects an invitation.
         *
         * @param request DeclineHandshakeRequest
         * @return DeclineHandshakeResponse
         */
        public async Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeclineHandshakeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a member of the resource account type.
         *
         * @description Before you delete a member, we recommend that you call the [CheckAccountDelete](~~CheckAccountDelete~~) and [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operations to check whether the member meets deletion requirements. You can call the DeleteAccount operation to delete only members that meet the deletion requirements.
         * After you submit a deletion request for a member, you can call the [GetAccountDeletionStatus](~~GetAccountDeletionStatus~~) operation to query the deletion status of the member. After a member is deleted, the resources and data within the member are deleted, and you can no longer use the member to log on to the Alibaba Cloud Management Console. In addition, the member cannot be recovered. Proceed with caution. For more information about how to delete a member, see [Delete a member of the resource account type](https://help.aliyun.com/document_detail/446078.html).
         *
         * @param tmpReq DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAccountShrinkRequest request = new DeleteAccountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AbandonableCheckId))
            {
                request.AbandonableCheckIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AbandonableCheckId, "AbandonableCheckId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbandonableCheckIdShrink))
            {
                query["AbandonableCheckId"] = request.AbandonableCheckIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a member of the resource account type.
         *
         * @description Before you delete a member, we recommend that you call the [CheckAccountDelete](~~CheckAccountDelete~~) and [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operations to check whether the member meets deletion requirements. You can call the DeleteAccount operation to delete only members that meet the deletion requirements.
         * After you submit a deletion request for a member, you can call the [GetAccountDeletionStatus](~~GetAccountDeletionStatus~~) operation to query the deletion status of the member. After a member is deleted, the resources and data within the member are deleted, and you can no longer use the member to log on to the Alibaba Cloud Management Console. In addition, the member cannot be recovered. Proceed with caution. For more information about how to delete a member, see [Delete a member of the resource account type](https://help.aliyun.com/document_detail/446078.html).
         *
         * @param tmpReq DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAccountShrinkRequest request = new DeleteAccountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AbandonableCheckId))
            {
                request.AbandonableCheckIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AbandonableCheckId, "AbandonableCheckId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbandonableCheckIdShrink))
            {
                query["AbandonableCheckId"] = request.AbandonableCheckIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a member of the resource account type.
         *
         * @description Before you delete a member, we recommend that you call the [CheckAccountDelete](~~CheckAccountDelete~~) and [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operations to check whether the member meets deletion requirements. You can call the DeleteAccount operation to delete only members that meet the deletion requirements.
         * After you submit a deletion request for a member, you can call the [GetAccountDeletionStatus](~~GetAccountDeletionStatus~~) operation to query the deletion status of the member. After a member is deleted, the resources and data within the member are deleted, and you can no longer use the member to log on to the Alibaba Cloud Management Console. In addition, the member cannot be recovered. Proceed with caution. For more information about how to delete a member, see [Delete a member of the resource account type](https://help.aliyun.com/document_detail/446078.html).
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a member of the resource account type.
         *
         * @description Before you delete a member, we recommend that you call the [CheckAccountDelete](~~CheckAccountDelete~~) and [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operations to check whether the member meets deletion requirements. You can call the DeleteAccount operation to delete only members that meet the deletion requirements.
         * After you submit a deletion request for a member, you can call the [GetAccountDeletionStatus](~~GetAccountDeletionStatus~~) operation to query the deletion status of the member. After a member is deleted, the resources and data within the member are deleted, and you can no longer use the member to log on to the Alibaba Cloud Management Console. In addition, the member cannot be recovered. Proceed with caution. For more information about how to delete a member, see [Delete a member of the resource account type](https://help.aliyun.com/document_detail/446078.html).
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a custom access control policy.
         *
         * @description If you want to delete a custom access control policy that is attached to folders or members, you must call the [DetachControlPolicy](~~DetachControlPolicy~~) operation to detach the policy before you delete it.
         *
         * @param request DeleteControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyResponse
         */
        public DeleteControlPolicyResponse DeleteControlPolicyWithOptions(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom access control policy.
         *
         * @description If you want to delete a custom access control policy that is attached to folders or members, you must call the [DetachControlPolicy](~~DetachControlPolicy~~) operation to detach the policy before you delete it.
         *
         * @param request DeleteControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyResponse
         */
        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyWithOptionsAsync(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom access control policy.
         *
         * @description If you want to delete a custom access control policy that is attached to folders or members, you must call the [DetachControlPolicy](~~DetachControlPolicy~~) operation to detach the policy before you delete it.
         *
         * @param request DeleteControlPolicyRequest
         * @return DeleteControlPolicyResponse
         */
        public DeleteControlPolicyResponse DeleteControlPolicy(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a custom access control policy.
         *
         * @description If you want to delete a custom access control policy that is attached to folders or members, you must call the [DetachControlPolicy](~~DetachControlPolicy~~) operation to detach the policy before you delete it.
         *
         * @param request DeleteControlPolicyRequest
         * @return DeleteControlPolicyResponse
         */
        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyAsync(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a folder.
         *
         * @description Before you delete a folder, you must make sure that the folder does not contain members or subfolders.
         *
         * @param request DeleteFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolderWithOptions(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a folder.
         *
         * @description Before you delete a folder, you must make sure that the folder does not contain members or subfolders.
         *
         * @param request DeleteFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a folder.
         *
         * @description Before you delete a folder, you must make sure that the folder does not contain members or subfolders.
         *
         * @param request DeleteFolderRequest
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFolderWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a folder.
         *
         * @description Before you delete a folder, you must make sure that the folder does not contain members or subfolders.
         *
         * @param request DeleteFolderRequest
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFolderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a contact.
         *
         * @param request DeleteMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMessageContactResponse
         */
        public DeleteMessageContactResponse DeleteMessageContactWithOptions(DeleteMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainContactInMembers))
            {
                query["RetainContactInMembers"] = request.RetainContactInMembers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a contact.
         *
         * @param request DeleteMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMessageContactResponse
         */
        public async Task<DeleteMessageContactResponse> DeleteMessageContactWithOptionsAsync(DeleteMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainContactInMembers))
            {
                query["RetainContactInMembers"] = request.RetainContactInMembers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a contact.
         *
         * @param request DeleteMessageContactRequest
         * @return DeleteMessageContactResponse
         */
        public DeleteMessageContactResponse DeleteMessageContact(DeleteMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a contact.
         *
         * @param request DeleteMessageContactRequest
         * @return DeleteMessageContactResponse
         */
        public async Task<DeleteMessageContactResponse> DeleteMessageContactAsync(DeleteMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMessageContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes a delegated administrator account for a trusted service.
         *
         * @description If the delegated administrator account that you want to remove has historical management tasks in the related trusted service, the trusted service may be affected after the delegated administrator account is removed. Therefore, proceed with caution.
         *
         * @param request DeregisterDelegatedAdministratorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeregisterDelegatedAdministratorResponse
         */
        public DeregisterDelegatedAdministratorResponse DeregisterDelegatedAdministratorWithOptions(DeregisterDelegatedAdministratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterDelegatedAdministrator",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterDelegatedAdministratorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes a delegated administrator account for a trusted service.
         *
         * @description If the delegated administrator account that you want to remove has historical management tasks in the related trusted service, the trusted service may be affected after the delegated administrator account is removed. Therefore, proceed with caution.
         *
         * @param request DeregisterDelegatedAdministratorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeregisterDelegatedAdministratorResponse
         */
        public async Task<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorWithOptionsAsync(DeregisterDelegatedAdministratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterDelegatedAdministrator",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterDelegatedAdministratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes a delegated administrator account for a trusted service.
         *
         * @description If the delegated administrator account that you want to remove has historical management tasks in the related trusted service, the trusted service may be affected after the delegated administrator account is removed. Therefore, proceed with caution.
         *
         * @param request DeregisterDelegatedAdministratorRequest
         * @return DeregisterDelegatedAdministratorResponse
         */
        public DeregisterDelegatedAdministratorResponse DeregisterDelegatedAdministrator(DeregisterDelegatedAdministratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterDelegatedAdministratorWithOptions(request, runtime);
        }

        /**
         * @summary Removes a delegated administrator account for a trusted service.
         *
         * @description If the delegated administrator account that you want to remove has historical management tasks in the related trusted service, the trusted service may be affected after the delegated administrator account is removed. Therefore, proceed with caution.
         *
         * @param request DeregisterDelegatedAdministratorRequest
         * @return DeregisterDelegatedAdministratorResponse
         */
        public async Task<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorAsync(DeregisterDelegatedAdministratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterDelegatedAdministratorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a resource directory. This operation cannot be undone. Therefore, proceed with caution.
         *
         * @description Before you disable a resource directory, you must make sure that the following requirements are met:
         * *   All members of the cloud account type in the resource directory are removed. You can call the [RemoveCloudAccount](~~RemoveCloudAccount~~) operation to remove a member of the cloud account type.
         * *   All folders except the Root folder are deleted from the resource directory. You can call the [DeleteFolder](~~DeleteFolder~~) operation to delete a folder.
         *
         * @param request DestroyResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DestroyResourceDirectoryResponse
         */
        public DestroyResourceDirectoryResponse DestroyResourceDirectoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables a resource directory. This operation cannot be undone. Therefore, proceed with caution.
         *
         * @description Before you disable a resource directory, you must make sure that the following requirements are met:
         * *   All members of the cloud account type in the resource directory are removed. You can call the [RemoveCloudAccount](~~RemoveCloudAccount~~) operation to remove a member of the cloud account type.
         * *   All folders except the Root folder are deleted from the resource directory. You can call the [DeleteFolder](~~DeleteFolder~~) operation to delete a folder.
         *
         * @param request DestroyResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DestroyResourceDirectoryResponse
         */
        public async Task<DestroyResourceDirectoryResponse> DestroyResourceDirectoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables a resource directory. This operation cannot be undone. Therefore, proceed with caution.
         *
         * @description Before you disable a resource directory, you must make sure that the following requirements are met:
         * *   All members of the cloud account type in the resource directory are removed. You can call the [RemoveCloudAccount](~~RemoveCloudAccount~~) operation to remove a member of the cloud account type.
         * *   All folders except the Root folder are deleted from the resource directory. You can call the [DeleteFolder](~~DeleteFolder~~) operation to delete a folder.
         *
         * @return DestroyResourceDirectoryResponse
         */
        public DestroyResourceDirectoryResponse DestroyResourceDirectory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyResourceDirectoryWithOptions(runtime);
        }

        /**
         * @summary Disables a resource directory. This operation cannot be undone. Therefore, proceed with caution.
         *
         * @description Before you disable a resource directory, you must make sure that the following requirements are met:
         * *   All members of the cloud account type in the resource directory are removed. You can call the [RemoveCloudAccount](~~RemoveCloudAccount~~) operation to remove a member of the cloud account type.
         * *   All folders except the Root folder are deleted from the resource directory. You can call the [DeleteFolder](~~DeleteFolder~~) operation to delete a folder.
         *
         * @return DestroyResourceDirectoryResponse
         */
        public async Task<DestroyResourceDirectoryResponse> DestroyResourceDirectoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyResourceDirectoryWithOptionsAsync(runtime);
        }

        /**
         * @summary Detaches an access control policy.
         *
         * @description After you detach an access control policy, the operations performed on resources by using members are not limited by the policy. Make sure that the detached policy meets your expectations. Otherwise, your business may be affected.
         * Both the system and custom access control policies can be detached. If an object has only one access control policy attached, the policy cannot be detached.
         *
         * @param request DetachControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachControlPolicyResponse
         */
        public DetachControlPolicyResponse DetachControlPolicyWithOptions(DetachControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches an access control policy.
         *
         * @description After you detach an access control policy, the operations performed on resources by using members are not limited by the policy. Make sure that the detached policy meets your expectations. Otherwise, your business may be affected.
         * Both the system and custom access control policies can be detached. If an object has only one access control policy attached, the policy cannot be detached.
         *
         * @param request DetachControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachControlPolicyResponse
         */
        public async Task<DetachControlPolicyResponse> DetachControlPolicyWithOptionsAsync(DetachControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches an access control policy.
         *
         * @description After you detach an access control policy, the operations performed on resources by using members are not limited by the policy. Make sure that the detached policy meets your expectations. Otherwise, your business may be affected.
         * Both the system and custom access control policies can be detached. If an object has only one access control policy attached, the policy cannot be detached.
         *
         * @param request DetachControlPolicyRequest
         * @return DetachControlPolicyResponse
         */
        public DetachControlPolicyResponse DetachControlPolicy(DetachControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Detaches an access control policy.
         *
         * @description After you detach an access control policy, the operations performed on resources by using members are not limited by the policy. Make sure that the detached policy meets your expectations. Otherwise, your business may be affected.
         * Both the system and custom access control policies can be detached. If an object has only one access control policy attached, the policy cannot be detached.
         *
         * @param request DetachControlPolicyRequest
         * @return DetachControlPolicyResponse
         */
        public async Task<DetachControlPolicyResponse> DetachControlPolicyAsync(DetachControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables the Control Policy feature.
         *
         * @description After you disable the Control Policy feature, the system automatically detaches all access control policies that are attached to folders and members. The system does not delete these access control policies, but you cannot attach them to folders or members again.
         * > If you disable the Control Policy feature, the permissions of all folders and members in your resource directory are affected. Therefore, proceed with caution.
         *
         * @param request DisableControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableControlPolicyResponse
         */
        public DisableControlPolicyResponse DisableControlPolicyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables the Control Policy feature.
         *
         * @description After you disable the Control Policy feature, the system automatically detaches all access control policies that are attached to folders and members. The system does not delete these access control policies, but you cannot attach them to folders or members again.
         * > If you disable the Control Policy feature, the permissions of all folders and members in your resource directory are affected. Therefore, proceed with caution.
         *
         * @param request DisableControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableControlPolicyResponse
         */
        public async Task<DisableControlPolicyResponse> DisableControlPolicyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables the Control Policy feature.
         *
         * @description After you disable the Control Policy feature, the system automatically detaches all access control policies that are attached to folders and members. The system does not delete these access control policies, but you cannot attach them to folders or members again.
         * > If you disable the Control Policy feature, the permissions of all folders and members in your resource directory are affected. Therefore, proceed with caution.
         *
         * @return DisableControlPolicyResponse
         */
        public DisableControlPolicyResponse DisableControlPolicy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableControlPolicyWithOptions(runtime);
        }

        /**
         * @summary Disables the Control Policy feature.
         *
         * @description After you disable the Control Policy feature, the system automatically detaches all access control policies that are attached to folders and members. The system does not delete these access control policies, but you cannot attach them to folders or members again.
         * > If you disable the Control Policy feature, the permissions of all folders and members in your resource directory are affected. Therefore, proceed with caution.
         *
         * @return DisableControlPolicyResponse
         */
        public async Task<DisableControlPolicyResponse> DisableControlPolicyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableControlPolicyWithOptionsAsync(runtime);
        }

        /**
         * @summary Unbinds a contact from a resource directory, folder, or member.
         *
         * @param request DisassociateMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisassociateMembersResponse
         */
        public DisassociateMembersResponse DisassociateMembersWithOptions(DisassociateMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateMembers",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unbinds a contact from a resource directory, folder, or member.
         *
         * @param request DisassociateMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisassociateMembersResponse
         */
        public async Task<DisassociateMembersResponse> DisassociateMembersWithOptionsAsync(DisassociateMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateMembers",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unbinds a contact from a resource directory, folder, or member.
         *
         * @param request DisassociateMembersRequest
         * @return DisassociateMembersResponse
         */
        public DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateMembersWithOptions(request, runtime);
        }

        /**
         * @summary Unbinds a contact from a resource directory, folder, or member.
         *
         * @param request DisassociateMembersRequest
         * @return DisassociateMembersResponse
         */
        public async Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the Control Policy feature.
         *
         * @description The Control Policy feature provided by the Resource Directory service allows you to manage the permission boundaries of the folders or members in your resource directory in a centralized manner. This feature is implemented based on the resource directory. You can use this feature to develop common or dedicated rules for access control. The Control Policy feature does not grant permissions but only defines permission boundaries. A member in a resource directory can be used to access resources only after it is granted the required permissions by using the Resource Access Management (RAM) service. For more information, see [Overview of the Control Policy feature](https://help.aliyun.com/document_detail/178671.html).
         *
         * @param request EnableControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableControlPolicyResponse
         */
        public EnableControlPolicyResponse EnableControlPolicyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the Control Policy feature.
         *
         * @description The Control Policy feature provided by the Resource Directory service allows you to manage the permission boundaries of the folders or members in your resource directory in a centralized manner. This feature is implemented based on the resource directory. You can use this feature to develop common or dedicated rules for access control. The Control Policy feature does not grant permissions but only defines permission boundaries. A member in a resource directory can be used to access resources only after it is granted the required permissions by using the Resource Access Management (RAM) service. For more information, see [Overview of the Control Policy feature](https://help.aliyun.com/document_detail/178671.html).
         *
         * @param request EnableControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableControlPolicyResponse
         */
        public async Task<EnableControlPolicyResponse> EnableControlPolicyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the Control Policy feature.
         *
         * @description The Control Policy feature provided by the Resource Directory service allows you to manage the permission boundaries of the folders or members in your resource directory in a centralized manner. This feature is implemented based on the resource directory. You can use this feature to develop common or dedicated rules for access control. The Control Policy feature does not grant permissions but only defines permission boundaries. A member in a resource directory can be used to access resources only after it is granted the required permissions by using the Resource Access Management (RAM) service. For more information, see [Overview of the Control Policy feature](https://help.aliyun.com/document_detail/178671.html).
         *
         * @return EnableControlPolicyResponse
         */
        public EnableControlPolicyResponse EnableControlPolicy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableControlPolicyWithOptions(runtime);
        }

        /**
         * @summary Enables the Control Policy feature.
         *
         * @description The Control Policy feature provided by the Resource Directory service allows you to manage the permission boundaries of the folders or members in your resource directory in a centralized manner. This feature is implemented based on the resource directory. You can use this feature to develop common or dedicated rules for access control. The Control Policy feature does not grant permissions but only defines permission boundaries. A member in a resource directory can be used to access resources only after it is granted the required permissions by using the Resource Access Management (RAM) service. For more information, see [Overview of the Control Policy feature](https://help.aliyun.com/document_detail/178671.html).
         *
         * @return EnableControlPolicyResponse
         */
        public async Task<EnableControlPolicyResponse> EnableControlPolicyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableControlPolicyWithOptionsAsync(runtime);
        }

        /**
         * @summary Enables a resource directory.
         *
         * @description You can use the current account or a newly created account to enable a resource directory. For more information, see [Enable a resource directory](https://help.aliyun.com/document_detail/111215.html).
         *
         * @param request EnableResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableResourceDirectoryResponse
         */
        public EnableResourceDirectoryResponse EnableResourceDirectoryWithOptions(EnableResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMode))
            {
                query["EnableMode"] = request.EnableMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MAName))
            {
                query["MAName"] = request.MAName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MASecureMobilePhone))
            {
                query["MASecureMobilePhone"] = request.MASecureMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables a resource directory.
         *
         * @description You can use the current account or a newly created account to enable a resource directory. For more information, see [Enable a resource directory](https://help.aliyun.com/document_detail/111215.html).
         *
         * @param request EnableResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableResourceDirectoryResponse
         */
        public async Task<EnableResourceDirectoryResponse> EnableResourceDirectoryWithOptionsAsync(EnableResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMode))
            {
                query["EnableMode"] = request.EnableMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MAName))
            {
                query["MAName"] = request.MAName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MASecureMobilePhone))
            {
                query["MASecureMobilePhone"] = request.MASecureMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables a resource directory.
         *
         * @description You can use the current account or a newly created account to enable a resource directory. For more information, see [Enable a resource directory](https://help.aliyun.com/document_detail/111215.html).
         *
         * @param request EnableResourceDirectoryRequest
         * @return EnableResourceDirectoryResponse
         */
        public EnableResourceDirectoryResponse EnableResourceDirectory(EnableResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableResourceDirectoryWithOptions(request, runtime);
        }

        /**
         * @summary Enables a resource directory.
         *
         * @description You can use the current account or a newly created account to enable a resource directory. For more information, see [Enable a resource directory](https://help.aliyun.com/document_detail/111215.html).
         *
         * @param request EnableResourceDirectoryRequest
         * @return EnableResourceDirectoryResponse
         */
        public async Task<EnableResourceDirectoryResponse> EnableResourceDirectoryAsync(EnableResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableResourceDirectoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of a member.
         *
         * @param request GetAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountResponse
         */
        public GetAccountResponse GetAccountWithOptions(GetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a member.
         *
         * @param request GetAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountResponse
         */
        public async Task<GetAccountResponse> GetAccountWithOptionsAsync(GetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a member.
         *
         * @param request GetAccountRequest
         * @return GetAccountResponse
         */
        public GetAccountResponse GetAccount(GetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of a member.
         *
         * @param request GetAccountRequest
         * @return GetAccountResponse
         */
        public async Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the result of a member deletion check.
         *
         * @description After you call the [CheckAccountDelete](~~CheckAccountDelete~~) operation to perform a member deletion check, you can call the [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operation to query the check result. If the check result shows that the member meets deletion requirements, you can delete the member. Otherwise, you need to first modify the items that do not meet requirements.
         *
         * @param request GetAccountDeletionCheckResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountDeletionCheckResultResponse
         */
        public GetAccountDeletionCheckResultResponse GetAccountDeletionCheckResultWithOptions(GetAccountDeletionCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountDeletionCheckResult",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountDeletionCheckResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the result of a member deletion check.
         *
         * @description After you call the [CheckAccountDelete](~~CheckAccountDelete~~) operation to perform a member deletion check, you can call the [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operation to query the check result. If the check result shows that the member meets deletion requirements, you can delete the member. Otherwise, you need to first modify the items that do not meet requirements.
         *
         * @param request GetAccountDeletionCheckResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountDeletionCheckResultResponse
         */
        public async Task<GetAccountDeletionCheckResultResponse> GetAccountDeletionCheckResultWithOptionsAsync(GetAccountDeletionCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountDeletionCheckResult",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountDeletionCheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the result of a member deletion check.
         *
         * @description After you call the [CheckAccountDelete](~~CheckAccountDelete~~) operation to perform a member deletion check, you can call the [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operation to query the check result. If the check result shows that the member meets deletion requirements, you can delete the member. Otherwise, you need to first modify the items that do not meet requirements.
         *
         * @param request GetAccountDeletionCheckResultRequest
         * @return GetAccountDeletionCheckResultResponse
         */
        public GetAccountDeletionCheckResultResponse GetAccountDeletionCheckResult(GetAccountDeletionCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountDeletionCheckResultWithOptions(request, runtime);
        }

        /**
         * @summary Queries the result of a member deletion check.
         *
         * @description After you call the [CheckAccountDelete](~~CheckAccountDelete~~) operation to perform a member deletion check, you can call the [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operation to query the check result. If the check result shows that the member meets deletion requirements, you can delete the member. Otherwise, you need to first modify the items that do not meet requirements.
         *
         * @param request GetAccountDeletionCheckResultRequest
         * @return GetAccountDeletionCheckResultResponse
         */
        public async Task<GetAccountDeletionCheckResultResponse> GetAccountDeletionCheckResultAsync(GetAccountDeletionCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountDeletionCheckResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the deletion status of a member.
         *
         * @param request GetAccountDeletionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountDeletionStatusResponse
         */
        public GetAccountDeletionStatusResponse GetAccountDeletionStatusWithOptions(GetAccountDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountDeletionStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountDeletionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the deletion status of a member.
         *
         * @param request GetAccountDeletionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountDeletionStatusResponse
         */
        public async Task<GetAccountDeletionStatusResponse> GetAccountDeletionStatusWithOptionsAsync(GetAccountDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountDeletionStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountDeletionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the deletion status of a member.
         *
         * @param request GetAccountDeletionStatusRequest
         * @return GetAccountDeletionStatusResponse
         */
        public GetAccountDeletionStatusResponse GetAccountDeletionStatus(GetAccountDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountDeletionStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the deletion status of a member.
         *
         * @param request GetAccountDeletionStatusRequest
         * @return GetAccountDeletionStatusResponse
         */
        public async Task<GetAccountDeletionStatusResponse> GetAccountDeletionStatusAsync(GetAccountDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountDeletionStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an access control policy.
         *
         * @param request GetControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetControlPolicyResponse
         */
        public GetControlPolicyResponse GetControlPolicyWithOptions(GetControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an access control policy.
         *
         * @param request GetControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetControlPolicyResponse
         */
        public async Task<GetControlPolicyResponse> GetControlPolicyWithOptionsAsync(GetControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an access control policy.
         *
         * @param request GetControlPolicyRequest
         * @return GetControlPolicyResponse
         */
        public GetControlPolicyResponse GetControlPolicy(GetControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an access control policy.
         *
         * @param request GetControlPolicyRequest
         * @return GetControlPolicyResponse
         */
        public async Task<GetControlPolicyResponse> GetControlPolicyAsync(GetControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of the Control Policy feature.
         *
         * @param request GetControlPolicyEnablementStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetControlPolicyEnablementStatusResponse
         */
        public GetControlPolicyEnablementStatusResponse GetControlPolicyEnablementStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetControlPolicyEnablementStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetControlPolicyEnablementStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of the Control Policy feature.
         *
         * @param request GetControlPolicyEnablementStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetControlPolicyEnablementStatusResponse
         */
        public async Task<GetControlPolicyEnablementStatusResponse> GetControlPolicyEnablementStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetControlPolicyEnablementStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetControlPolicyEnablementStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of the Control Policy feature.
         *
         * @return GetControlPolicyEnablementStatusResponse
         */
        public GetControlPolicyEnablementStatusResponse GetControlPolicyEnablementStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetControlPolicyEnablementStatusWithOptions(runtime);
        }

        /**
         * @summary Queries the status of the Control Policy feature.
         *
         * @return GetControlPolicyEnablementStatusResponse
         */
        public async Task<GetControlPolicyEnablementStatusResponse> GetControlPolicyEnablementStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetControlPolicyEnablementStatusWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the information about a folder.
         *
         * @param request GetFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFolderResponse
         */
        public GetFolderResponse GetFolderWithOptions(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a folder.
         *
         * @param request GetFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFolderResponse
         */
        public async Task<GetFolderResponse> GetFolderWithOptionsAsync(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a folder.
         *
         * @param request GetFolderRequest
         * @return GetFolderResponse
         */
        public GetFolderResponse GetFolder(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFolderWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a folder.
         *
         * @param request GetFolderRequest
         * @return GetFolderResponse
         */
        public async Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFolderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of an invitation.
         *
         * @param request GetHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHandshakeResponse
         */
        public GetHandshakeResponse GetHandshakeWithOptions(GetHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHandshakeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of an invitation.
         *
         * @param request GetHandshakeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHandshakeResponse
         */
        public async Task<GetHandshakeResponse> GetHandshakeWithOptionsAsync(GetHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandshakeId))
            {
                query["HandshakeId"] = request.HandshakeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHandshake",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHandshakeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of an invitation.
         *
         * @param request GetHandshakeRequest
         * @return GetHandshakeResponse
         */
        public GetHandshakeResponse GetHandshake(GetHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHandshakeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of an invitation.
         *
         * @param request GetHandshakeRequest
         * @return GetHandshakeResponse
         */
        public async Task<GetHandshakeResponse> GetHandshakeAsync(GetHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHandshakeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a contact.
         *
         * @param request GetMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageContactResponse
         */
        public GetMessageContactResponse GetMessageContactWithOptions(GetMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a contact.
         *
         * @param request GetMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageContactResponse
         */
        public async Task<GetMessageContactResponse> GetMessageContactWithOptionsAsync(GetMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a contact.
         *
         * @param request GetMessageContactRequest
         * @return GetMessageContactResponse
         */
        public GetMessageContactResponse GetMessageContact(GetMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a contact.
         *
         * @param request GetMessageContactRequest
         * @return GetMessageContactResponse
         */
        public async Task<GetMessageContactResponse> GetMessageContactAsync(GetMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessageContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the deletion status of a contact.
         *
         * @param request GetMessageContactDeletionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageContactDeletionStatusResponse
         */
        public GetMessageContactDeletionStatusResponse GetMessageContactDeletionStatusWithOptions(GetMessageContactDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageContactDeletionStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageContactDeletionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the deletion status of a contact.
         *
         * @param request GetMessageContactDeletionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageContactDeletionStatusResponse
         */
        public async Task<GetMessageContactDeletionStatusResponse> GetMessageContactDeletionStatusWithOptionsAsync(GetMessageContactDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageContactDeletionStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageContactDeletionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the deletion status of a contact.
         *
         * @param request GetMessageContactDeletionStatusRequest
         * @return GetMessageContactDeletionStatusResponse
         */
        public GetMessageContactDeletionStatusResponse GetMessageContactDeletionStatus(GetMessageContactDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessageContactDeletionStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the deletion status of a contact.
         *
         * @param request GetMessageContactDeletionStatusRequest
         * @return GetMessageContactDeletionStatusResponse
         */
        public async Task<GetMessageContactDeletionStatusResponse> GetMessageContactDeletionStatusAsync(GetMessageContactDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessageContactDeletionStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of a billing account.
         *
         * @param request GetPayerForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPayerForAccountResponse
         */
        public GetPayerForAccountResponse GetPayerForAccountWithOptions(GetPayerForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPayerForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPayerForAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a billing account.
         *
         * @param request GetPayerForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPayerForAccountResponse
         */
        public async Task<GetPayerForAccountResponse> GetPayerForAccountWithOptionsAsync(GetPayerForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPayerForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPayerForAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a billing account.
         *
         * @param request GetPayerForAccountRequest
         * @return GetPayerForAccountResponse
         */
        public GetPayerForAccountResponse GetPayerForAccount(GetPayerForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPayerForAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of a billing account.
         *
         * @param request GetPayerForAccountRequest
         * @return GetPayerForAccountResponse
         */
        public async Task<GetPayerForAccountResponse> GetPayerForAccountAsync(GetPayerForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPayerForAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary \\*\\*\\* Co., Ltd.
         *
         * @param request GetResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceDirectoryResponse
         */
        public GetResourceDirectoryResponse GetResourceDirectoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary \\*\\*\\* Co., Ltd.
         *
         * @param request GetResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceDirectoryResponse
         */
        public async Task<GetResourceDirectoryResponse> GetResourceDirectoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary \\*\\*\\* Co., Ltd.
         *
         * @return GetResourceDirectoryResponse
         */
        public GetResourceDirectoryResponse GetResourceDirectory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceDirectoryWithOptions(runtime);
        }

        /**
         * @summary \\*\\*\\* Co., Ltd.
         *
         * @return GetResourceDirectoryResponse
         */
        public async Task<GetResourceDirectoryResponse> GetResourceDirectoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceDirectoryWithOptionsAsync(runtime);
        }

        /**
         * @summary Invites an account to join a resource directory.
         *
         * @param request InviteAccountToResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InviteAccountToResourceDirectoryResponse
         */
        public InviteAccountToResourceDirectoryResponse InviteAccountToResourceDirectoryWithOptions(InviteAccountToResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEntity))
            {
                query["TargetEntity"] = request.TargetEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteAccountToResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteAccountToResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Invites an account to join a resource directory.
         *
         * @param request InviteAccountToResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InviteAccountToResourceDirectoryResponse
         */
        public async Task<InviteAccountToResourceDirectoryResponse> InviteAccountToResourceDirectoryWithOptionsAsync(InviteAccountToResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEntity))
            {
                query["TargetEntity"] = request.TargetEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteAccountToResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteAccountToResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Invites an account to join a resource directory.
         *
         * @param request InviteAccountToResourceDirectoryRequest
         * @return InviteAccountToResourceDirectoryResponse
         */
        public InviteAccountToResourceDirectoryResponse InviteAccountToResourceDirectory(InviteAccountToResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteAccountToResourceDirectoryWithOptions(request, runtime);
        }

        /**
         * @summary Invites an account to join a resource directory.
         *
         * @param request InviteAccountToResourceDirectoryRequest
         * @return InviteAccountToResourceDirectoryResponse
         */
        public async Task<InviteAccountToResourceDirectoryResponse> InviteAccountToResourceDirectoryAsync(InviteAccountToResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteAccountToResourceDirectoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all the members in a resource directory.
         *
         * @description You can use only the management account of a resource directory or a delegated administrator account of a trusted service to call this operation.
         *
         * @param request ListAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsResponse
         */
        public ListAccountsResponse ListAccountsWithOptions(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccounts",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all the members in a resource directory.
         *
         * @description You can use only the management account of a resource directory or a delegated administrator account of a trusted service to call this operation.
         *
         * @param request ListAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsResponse
         */
        public async Task<ListAccountsResponse> ListAccountsWithOptionsAsync(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccounts",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all the members in a resource directory.
         *
         * @description You can use only the management account of a resource directory or a delegated administrator account of a trusted service to call this operation.
         *
         * @param request ListAccountsRequest
         * @return ListAccountsResponse
         */
        public ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all the members in a resource directory.
         *
         * @description You can use only the management account of a resource directory or a delegated administrator account of a trusted service to call this operation.
         *
         * @param request ListAccountsRequest
         * @return ListAccountsResponse
         */
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of members in a folder.
         *
         * @param request ListAccountsForParentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsForParentResponse
         */
        public ListAccountsForParentResponse ListAccountsForParentWithOptions(ListAccountsForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsForParent",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsForParentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of members in a folder.
         *
         * @param request ListAccountsForParentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsForParentResponse
         */
        public async Task<ListAccountsForParentResponse> ListAccountsForParentWithOptionsAsync(ListAccountsForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsForParent",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsForParentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of members in a folder.
         *
         * @param request ListAccountsForParentRequest
         * @return ListAccountsForParentResponse
         */
        public ListAccountsForParentResponse ListAccountsForParent(ListAccountsForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsForParentWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of members in a folder.
         *
         * @param request ListAccountsForParentRequest
         * @return ListAccountsForParentResponse
         */
        public async Task<ListAccountsForParentResponse> ListAccountsForParentAsync(ListAccountsForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsForParentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of all the parent folders of a specified folder.
         *
         * @param request ListAncestorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAncestorsResponse
         */
        public ListAncestorsResponse ListAncestorsWithOptions(ListAncestorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildId))
            {
                query["ChildId"] = request.ChildId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAncestors",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAncestorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of all the parent folders of a specified folder.
         *
         * @param request ListAncestorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAncestorsResponse
         */
        public async Task<ListAncestorsResponse> ListAncestorsWithOptionsAsync(ListAncestorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildId))
            {
                query["ChildId"] = request.ChildId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAncestors",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAncestorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of all the parent folders of a specified folder.
         *
         * @param request ListAncestorsRequest
         * @return ListAncestorsResponse
         */
        public ListAncestorsResponse ListAncestors(ListAncestorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAncestorsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of all the parent folders of a specified folder.
         *
         * @param request ListAncestorsRequest
         * @return ListAncestorsResponse
         */
        public async Task<ListAncestorsResponse> ListAncestorsAsync(ListAncestorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAncestorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries access control policies.
         *
         * @param request ListControlPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListControlPoliciesResponse
         */
        public ListControlPoliciesResponse ListControlPoliciesWithOptions(ListControlPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListControlPolicies",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListControlPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries access control policies.
         *
         * @param request ListControlPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListControlPoliciesResponse
         */
        public async Task<ListControlPoliciesResponse> ListControlPoliciesWithOptionsAsync(ListControlPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListControlPolicies",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListControlPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries access control policies.
         *
         * @param request ListControlPoliciesRequest
         * @return ListControlPoliciesResponse
         */
        public ListControlPoliciesResponse ListControlPolicies(ListControlPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListControlPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries access control policies.
         *
         * @param request ListControlPoliciesRequest
         * @return ListControlPoliciesResponse
         */
        public async Task<ListControlPoliciesResponse> ListControlPoliciesAsync(ListControlPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListControlPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the access control policies that are attached to a folder or member.
         *
         * @param request ListControlPolicyAttachmentsForTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListControlPolicyAttachmentsForTargetResponse
         */
        public ListControlPolicyAttachmentsForTargetResponse ListControlPolicyAttachmentsForTargetWithOptions(ListControlPolicyAttachmentsForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListControlPolicyAttachmentsForTarget",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListControlPolicyAttachmentsForTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the access control policies that are attached to a folder or member.
         *
         * @param request ListControlPolicyAttachmentsForTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListControlPolicyAttachmentsForTargetResponse
         */
        public async Task<ListControlPolicyAttachmentsForTargetResponse> ListControlPolicyAttachmentsForTargetWithOptionsAsync(ListControlPolicyAttachmentsForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListControlPolicyAttachmentsForTarget",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListControlPolicyAttachmentsForTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the access control policies that are attached to a folder or member.
         *
         * @param request ListControlPolicyAttachmentsForTargetRequest
         * @return ListControlPolicyAttachmentsForTargetResponse
         */
        public ListControlPolicyAttachmentsForTargetResponse ListControlPolicyAttachmentsForTarget(ListControlPolicyAttachmentsForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListControlPolicyAttachmentsForTargetWithOptions(request, runtime);
        }

        /**
         * @summary Queries the access control policies that are attached to a folder or member.
         *
         * @param request ListControlPolicyAttachmentsForTargetRequest
         * @return ListControlPolicyAttachmentsForTargetResponse
         */
        public async Task<ListControlPolicyAttachmentsForTargetResponse> ListControlPolicyAttachmentsForTargetAsync(ListControlPolicyAttachmentsForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListControlPolicyAttachmentsForTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries delegated administrator accounts.
         *
         * @param request ListDelegatedAdministratorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDelegatedAdministratorsResponse
         */
        public ListDelegatedAdministratorsResponse ListDelegatedAdministratorsWithOptions(ListDelegatedAdministratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelegatedAdministrators",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDelegatedAdministratorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries delegated administrator accounts.
         *
         * @param request ListDelegatedAdministratorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDelegatedAdministratorsResponse
         */
        public async Task<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsWithOptionsAsync(ListDelegatedAdministratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelegatedAdministrators",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDelegatedAdministratorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries delegated administrator accounts.
         *
         * @param request ListDelegatedAdministratorsRequest
         * @return ListDelegatedAdministratorsResponse
         */
        public ListDelegatedAdministratorsResponse ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDelegatedAdministratorsWithOptions(request, runtime);
        }

        /**
         * @summary Queries delegated administrator accounts.
         *
         * @param request ListDelegatedAdministratorsRequest
         * @return ListDelegatedAdministratorsResponse
         */
        public async Task<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsAsync(ListDelegatedAdministratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDelegatedAdministratorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trusted services for which a member is specified as a delegated administrator account.
         *
         * @param request ListDelegatedServicesForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDelegatedServicesForAccountResponse
         */
        public ListDelegatedServicesForAccountResponse ListDelegatedServicesForAccountWithOptions(ListDelegatedServicesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelegatedServicesForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDelegatedServicesForAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trusted services for which a member is specified as a delegated administrator account.
         *
         * @param request ListDelegatedServicesForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDelegatedServicesForAccountResponse
         */
        public async Task<ListDelegatedServicesForAccountResponse> ListDelegatedServicesForAccountWithOptionsAsync(ListDelegatedServicesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelegatedServicesForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDelegatedServicesForAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trusted services for which a member is specified as a delegated administrator account.
         *
         * @param request ListDelegatedServicesForAccountRequest
         * @return ListDelegatedServicesForAccountResponse
         */
        public ListDelegatedServicesForAccountResponse ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDelegatedServicesForAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trusted services for which a member is specified as a delegated administrator account.
         *
         * @param request ListDelegatedServicesForAccountRequest
         * @return ListDelegatedServicesForAccountResponse
         */
        public async Task<ListDelegatedServicesForAccountResponse> ListDelegatedServicesForAccountAsync(ListDelegatedServicesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDelegatedServicesForAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of all subfolders of a folder.
         *
         * @description You can call this API operation to view the information of only the first-level subfolders of a folder.
         *
         * @param request ListFoldersForParentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFoldersForParentResponse
         */
        public ListFoldersForParentResponse ListFoldersForParentWithOptions(ListFoldersForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoldersForParent",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoldersForParentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of all subfolders of a folder.
         *
         * @description You can call this API operation to view the information of only the first-level subfolders of a folder.
         *
         * @param request ListFoldersForParentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFoldersForParentResponse
         */
        public async Task<ListFoldersForParentResponse> ListFoldersForParentWithOptionsAsync(ListFoldersForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                query["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoldersForParent",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoldersForParentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of all subfolders of a folder.
         *
         * @description You can call this API operation to view the information of only the first-level subfolders of a folder.
         *
         * @param request ListFoldersForParentRequest
         * @return ListFoldersForParentResponse
         */
        public ListFoldersForParentResponse ListFoldersForParent(ListFoldersForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFoldersForParentWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of all subfolders of a folder.
         *
         * @description You can call this API operation to view the information of only the first-level subfolders of a folder.
         *
         * @param request ListFoldersForParentRequest
         * @return ListFoldersForParentResponse
         */
        public async Task<ListFoldersForParentResponse> ListFoldersForParentAsync(ListFoldersForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFoldersForParentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the invitations that are associated with an account.
         *
         * @param request ListHandshakesForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHandshakesForAccountResponse
         */
        public ListHandshakesForAccountResponse ListHandshakesForAccountWithOptions(ListHandshakesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHandshakesForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHandshakesForAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the invitations that are associated with an account.
         *
         * @param request ListHandshakesForAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHandshakesForAccountResponse
         */
        public async Task<ListHandshakesForAccountResponse> ListHandshakesForAccountWithOptionsAsync(ListHandshakesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHandshakesForAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHandshakesForAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the invitations that are associated with an account.
         *
         * @param request ListHandshakesForAccountRequest
         * @return ListHandshakesForAccountResponse
         */
        public ListHandshakesForAccountResponse ListHandshakesForAccount(ListHandshakesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHandshakesForAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the invitations that are associated with an account.
         *
         * @param request ListHandshakesForAccountRequest
         * @return ListHandshakesForAccountResponse
         */
        public async Task<ListHandshakesForAccountResponse> ListHandshakesForAccountAsync(ListHandshakesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHandshakesForAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries invitations in a resource directory.
         *
         * @param request ListHandshakesForResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHandshakesForResourceDirectoryResponse
         */
        public ListHandshakesForResourceDirectoryResponse ListHandshakesForResourceDirectoryWithOptions(ListHandshakesForResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHandshakesForResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHandshakesForResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries invitations in a resource directory.
         *
         * @param request ListHandshakesForResourceDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHandshakesForResourceDirectoryResponse
         */
        public async Task<ListHandshakesForResourceDirectoryResponse> ListHandshakesForResourceDirectoryWithOptionsAsync(ListHandshakesForResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHandshakesForResourceDirectory",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHandshakesForResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries invitations in a resource directory.
         *
         * @param request ListHandshakesForResourceDirectoryRequest
         * @return ListHandshakesForResourceDirectoryResponse
         */
        public ListHandshakesForResourceDirectoryResponse ListHandshakesForResourceDirectory(ListHandshakesForResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHandshakesForResourceDirectoryWithOptions(request, runtime);
        }

        /**
         * @summary Queries invitations in a resource directory.
         *
         * @param request ListHandshakesForResourceDirectoryRequest
         * @return ListHandshakesForResourceDirectoryResponse
         */
        public async Task<ListHandshakesForResourceDirectoryResponse> ListHandshakesForResourceDirectoryAsync(ListHandshakesForResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHandshakesForResourceDirectoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the mobile phone number or email address to be verified for a contact.
         *
         * @param request ListMessageContactVerificationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessageContactVerificationsResponse
         */
        public ListMessageContactVerificationsResponse ListMessageContactVerificationsWithOptions(ListMessageContactVerificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessageContactVerifications",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessageContactVerificationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the mobile phone number or email address to be verified for a contact.
         *
         * @param request ListMessageContactVerificationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessageContactVerificationsResponse
         */
        public async Task<ListMessageContactVerificationsResponse> ListMessageContactVerificationsWithOptionsAsync(ListMessageContactVerificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessageContactVerifications",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessageContactVerificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the mobile phone number or email address to be verified for a contact.
         *
         * @param request ListMessageContactVerificationsRequest
         * @return ListMessageContactVerificationsResponse
         */
        public ListMessageContactVerificationsResponse ListMessageContactVerifications(ListMessageContactVerificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMessageContactVerificationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the mobile phone number or email address to be verified for a contact.
         *
         * @param request ListMessageContactVerificationsRequest
         * @return ListMessageContactVerificationsResponse
         */
        public async Task<ListMessageContactVerificationsResponse> ListMessageContactVerificationsAsync(ListMessageContactVerificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMessageContactVerificationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries contacts.
         *
         * @param request ListMessageContactsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessageContactsResponse
         */
        public ListMessageContactsResponse ListMessageContactsWithOptions(ListMessageContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Member))
            {
                query["Member"] = request.Member;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessageContacts",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessageContactsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries contacts.
         *
         * @param request ListMessageContactsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessageContactsResponse
         */
        public async Task<ListMessageContactsResponse> ListMessageContactsWithOptionsAsync(ListMessageContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Member))
            {
                query["Member"] = request.Member;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessageContacts",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessageContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries contacts.
         *
         * @param request ListMessageContactsRequest
         * @return ListMessageContactsResponse
         */
        public ListMessageContactsResponse ListMessageContacts(ListMessageContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMessageContactsWithOptions(request, runtime);
        }

        /**
         * @summary Queries contacts.
         *
         * @param request ListMessageContactsRequest
         * @return ListMessageContactsResponse
         */
        public async Task<ListMessageContactsResponse> ListMessageContactsAsync(ListMessageContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMessageContactsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyFilter))
            {
                query["KeyFilter"] = request.KeyFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyFilter))
            {
                query["KeyFilter"] = request.KeyFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to the members in a resource directory.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are added to the members in a resource directory.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are added to the members in a resource directory.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to the members in a resource directory.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilter))
            {
                query["ValueFilter"] = request.ValueFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilter))
            {
                query["ValueFilter"] = request.ValueFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the objects to which an access control policy is attached.
         *
         * @param request ListTargetAttachmentsForControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTargetAttachmentsForControlPolicyResponse
         */
        public ListTargetAttachmentsForControlPolicyResponse ListTargetAttachmentsForControlPolicyWithOptions(ListTargetAttachmentsForControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargetAttachmentsForControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetAttachmentsForControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the objects to which an access control policy is attached.
         *
         * @param request ListTargetAttachmentsForControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTargetAttachmentsForControlPolicyResponse
         */
        public async Task<ListTargetAttachmentsForControlPolicyResponse> ListTargetAttachmentsForControlPolicyWithOptionsAsync(ListTargetAttachmentsForControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargetAttachmentsForControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetAttachmentsForControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the objects to which an access control policy is attached.
         *
         * @param request ListTargetAttachmentsForControlPolicyRequest
         * @return ListTargetAttachmentsForControlPolicyResponse
         */
        public ListTargetAttachmentsForControlPolicyResponse ListTargetAttachmentsForControlPolicy(ListTargetAttachmentsForControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTargetAttachmentsForControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the objects to which an access control policy is attached.
         *
         * @param request ListTargetAttachmentsForControlPolicyRequest
         * @return ListTargetAttachmentsForControlPolicyResponse
         */
        public async Task<ListTargetAttachmentsForControlPolicyResponse> ListTargetAttachmentsForControlPolicyAsync(ListTargetAttachmentsForControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTargetAttachmentsForControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trusted services that are enabled within a management account or delegated administrator account.
         *
         * @description Only a management account or delegated administrator account can be used to call this operation.
         *
         * @param request ListTrustedServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrustedServiceStatusResponse
         */
        public ListTrustedServiceStatusResponse ListTrustedServiceStatusWithOptions(ListTrustedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminAccountId))
            {
                query["AdminAccountId"] = request.AdminAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrustedServiceStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrustedServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trusted services that are enabled within a management account or delegated administrator account.
         *
         * @description Only a management account or delegated administrator account can be used to call this operation.
         *
         * @param request ListTrustedServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrustedServiceStatusResponse
         */
        public async Task<ListTrustedServiceStatusResponse> ListTrustedServiceStatusWithOptionsAsync(ListTrustedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminAccountId))
            {
                query["AdminAccountId"] = request.AdminAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrustedServiceStatus",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrustedServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trusted services that are enabled within a management account or delegated administrator account.
         *
         * @description Only a management account or delegated administrator account can be used to call this operation.
         *
         * @param request ListTrustedServiceStatusRequest
         * @return ListTrustedServiceStatusResponse
         */
        public ListTrustedServiceStatusResponse ListTrustedServiceStatus(ListTrustedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrustedServiceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trusted services that are enabled within a management account or delegated administrator account.
         *
         * @description Only a management account or delegated administrator account can be used to call this operation.
         *
         * @param request ListTrustedServiceStatusRequest
         * @return ListTrustedServiceStatusResponse
         */
        public async Task<ListTrustedServiceStatusResponse> ListTrustedServiceStatusAsync(ListTrustedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrustedServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves a member from a folder to another.
         *
         * @param request MoveAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveAccountResponse
         */
        public MoveAccountResponse MoveAccountWithOptions(MoveAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationFolderId))
            {
                query["DestinationFolderId"] = request.DestinationFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves a member from a folder to another.
         *
         * @param request MoveAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveAccountResponse
         */
        public async Task<MoveAccountResponse> MoveAccountWithOptionsAsync(MoveAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationFolderId))
            {
                query["DestinationFolderId"] = request.DestinationFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves a member from a folder to another.
         *
         * @param request MoveAccountRequest
         * @return MoveAccountResponse
         */
        public MoveAccountResponse MoveAccount(MoveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveAccountWithOptions(request, runtime);
        }

        /**
         * @summary Moves a member from a folder to another.
         *
         * @param request MoveAccountRequest
         * @return MoveAccountResponse
         */
        public async Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether a management account or member can be used as a main financial account.
         *
         * @param request PrecheckForConsolidatedBillingAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrecheckForConsolidatedBillingAccountResponse
         */
        public PrecheckForConsolidatedBillingAccountResponse PrecheckForConsolidatedBillingAccountWithOptions(PrecheckForConsolidatedBillingAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingAccountId))
            {
                query["BillingAccountId"] = request.BillingAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckForConsolidatedBillingAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckForConsolidatedBillingAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Checks whether a management account or member can be used as a main financial account.
         *
         * @param request PrecheckForConsolidatedBillingAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrecheckForConsolidatedBillingAccountResponse
         */
        public async Task<PrecheckForConsolidatedBillingAccountResponse> PrecheckForConsolidatedBillingAccountWithOptionsAsync(PrecheckForConsolidatedBillingAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingAccountId))
            {
                query["BillingAccountId"] = request.BillingAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckForConsolidatedBillingAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckForConsolidatedBillingAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Checks whether a management account or member can be used as a main financial account.
         *
         * @param request PrecheckForConsolidatedBillingAccountRequest
         * @return PrecheckForConsolidatedBillingAccountResponse
         */
        public PrecheckForConsolidatedBillingAccountResponse PrecheckForConsolidatedBillingAccount(PrecheckForConsolidatedBillingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrecheckForConsolidatedBillingAccountWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether a management account or member can be used as a main financial account.
         *
         * @param request PrecheckForConsolidatedBillingAccountRequest
         * @return PrecheckForConsolidatedBillingAccountResponse
         */
        public async Task<PrecheckForConsolidatedBillingAccountResponse> PrecheckForConsolidatedBillingAccountAsync(PrecheckForConsolidatedBillingAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrecheckForConsolidatedBillingAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Specifies a member in a resource directory as a delegated administrator account of a trusted service.
         *
         * @description The delegated administrator account can be used to access the information of the resource directory and view the structure and members of the resource directory. The delegated administrator account can also be used to perform service-related management operations in the trusted service on behalf of the management account of the resource directory. When you call this operation, you must take note of the following limits:
         * *   Only some trusted services support delegated administrator accounts. For more information, see [Supported trusted services](https://help.aliyun.com/document_detail/208133.html).
         * *   Only the management account of a resource directory or an authorized RAM user or RAM role of the management account can be used to call this operation.
         * *   The number of delegated administrator accounts that are allowed for a trusted service is defined by the trusted service.
         *
         * @param request RegisterDelegatedAdministratorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDelegatedAdministratorResponse
         */
        public RegisterDelegatedAdministratorResponse RegisterDelegatedAdministratorWithOptions(RegisterDelegatedAdministratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDelegatedAdministrator",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDelegatedAdministratorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Specifies a member in a resource directory as a delegated administrator account of a trusted service.
         *
         * @description The delegated administrator account can be used to access the information of the resource directory and view the structure and members of the resource directory. The delegated administrator account can also be used to perform service-related management operations in the trusted service on behalf of the management account of the resource directory. When you call this operation, you must take note of the following limits:
         * *   Only some trusted services support delegated administrator accounts. For more information, see [Supported trusted services](https://help.aliyun.com/document_detail/208133.html).
         * *   Only the management account of a resource directory or an authorized RAM user or RAM role of the management account can be used to call this operation.
         * *   The number of delegated administrator accounts that are allowed for a trusted service is defined by the trusted service.
         *
         * @param request RegisterDelegatedAdministratorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDelegatedAdministratorResponse
         */
        public async Task<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorWithOptionsAsync(RegisterDelegatedAdministratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePrincipal))
            {
                query["ServicePrincipal"] = request.ServicePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDelegatedAdministrator",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDelegatedAdministratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Specifies a member in a resource directory as a delegated administrator account of a trusted service.
         *
         * @description The delegated administrator account can be used to access the information of the resource directory and view the structure and members of the resource directory. The delegated administrator account can also be used to perform service-related management operations in the trusted service on behalf of the management account of the resource directory. When you call this operation, you must take note of the following limits:
         * *   Only some trusted services support delegated administrator accounts. For more information, see [Supported trusted services](https://help.aliyun.com/document_detail/208133.html).
         * *   Only the management account of a resource directory or an authorized RAM user or RAM role of the management account can be used to call this operation.
         * *   The number of delegated administrator accounts that are allowed for a trusted service is defined by the trusted service.
         *
         * @param request RegisterDelegatedAdministratorRequest
         * @return RegisterDelegatedAdministratorResponse
         */
        public RegisterDelegatedAdministratorResponse RegisterDelegatedAdministrator(RegisterDelegatedAdministratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDelegatedAdministratorWithOptions(request, runtime);
        }

        /**
         * @summary Specifies a member in a resource directory as a delegated administrator account of a trusted service.
         *
         * @description The delegated administrator account can be used to access the information of the resource directory and view the structure and members of the resource directory. The delegated administrator account can also be used to perform service-related management operations in the trusted service on behalf of the management account of the resource directory. When you call this operation, you must take note of the following limits:
         * *   Only some trusted services support delegated administrator accounts. For more information, see [Supported trusted services](https://help.aliyun.com/document_detail/208133.html).
         * *   Only the management account of a resource directory or an authorized RAM user or RAM role of the management account can be used to call this operation.
         * *   The number of delegated administrator accounts that are allowed for a trusted service is defined by the trusted service.
         *
         * @param request RegisterDelegatedAdministratorRequest
         * @return RegisterDelegatedAdministratorResponse
         */
        public async Task<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorAsync(RegisterDelegatedAdministratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDelegatedAdministratorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes a member of the cloud account type.
         *
         * @param request RemoveCloudAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveCloudAccountResponse
         */
        public RemoveCloudAccountResponse RemoveCloudAccountWithOptions(RemoveCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveCloudAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveCloudAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes a member of the cloud account type.
         *
         * @param request RemoveCloudAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveCloudAccountResponse
         */
        public async Task<RemoveCloudAccountResponse> RemoveCloudAccountWithOptionsAsync(RemoveCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveCloudAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveCloudAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes a member of the cloud account type.
         *
         * @param request RemoveCloudAccountRequest
         * @return RemoveCloudAccountResponse
         */
        public RemoveCloudAccountResponse RemoveCloudAccount(RemoveCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveCloudAccountWithOptions(request, runtime);
        }

        /**
         * @summary Removes a member of the cloud account type.
         *
         * @param request RemoveCloudAccountRequest
         * @return RemoveCloudAccountResponse
         */
        public async Task<RemoveCloudAccountResponse> RemoveCloudAccountAsync(RemoveCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveCloudAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resends a verification email for the email address change of a member.
         *
         * @param request RetryChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryChangeAccountEmailResponse
         */
        public RetryChangeAccountEmailResponse RetryChangeAccountEmailWithOptions(RetryChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryChangeAccountEmailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resends a verification email for the email address change of a member.
         *
         * @param request RetryChangeAccountEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryChangeAccountEmailResponse
         */
        public async Task<RetryChangeAccountEmailResponse> RetryChangeAccountEmailWithOptionsAsync(RetryChangeAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryChangeAccountEmail",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryChangeAccountEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resends a verification email for the email address change of a member.
         *
         * @param request RetryChangeAccountEmailRequest
         * @return RetryChangeAccountEmailResponse
         */
        public RetryChangeAccountEmailResponse RetryChangeAccountEmail(RetryChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryChangeAccountEmailWithOptions(request, runtime);
        }

        /**
         * @summary Resends a verification email for the email address change of a member.
         *
         * @param request RetryChangeAccountEmailRequest
         * @return RetryChangeAccountEmailResponse
         */
        public async Task<RetryChangeAccountEmailResponse> RetryChangeAccountEmailAsync(RetryChangeAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryChangeAccountEmailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sends verification information to the email address of a contact.
         *
         * @param request SendEmailVerificationForMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendEmailVerificationForMessageContactResponse
         */
        public SendEmailVerificationForMessageContactResponse SendEmailVerificationForMessageContactWithOptions(SendEmailVerificationForMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendEmailVerificationForMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendEmailVerificationForMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sends verification information to the email address of a contact.
         *
         * @param request SendEmailVerificationForMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendEmailVerificationForMessageContactResponse
         */
        public async Task<SendEmailVerificationForMessageContactResponse> SendEmailVerificationForMessageContactWithOptionsAsync(SendEmailVerificationForMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendEmailVerificationForMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendEmailVerificationForMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sends verification information to the email address of a contact.
         *
         * @param request SendEmailVerificationForMessageContactRequest
         * @return SendEmailVerificationForMessageContactResponse
         */
        public SendEmailVerificationForMessageContactResponse SendEmailVerificationForMessageContact(SendEmailVerificationForMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendEmailVerificationForMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Sends verification information to the email address of a contact.
         *
         * @param request SendEmailVerificationForMessageContactRequest
         * @return SendEmailVerificationForMessageContactResponse
         */
        public async Task<SendEmailVerificationForMessageContactResponse> SendEmailVerificationForMessageContactAsync(SendEmailVerificationForMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendEmailVerificationForMessageContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sends verification information to the mobile phone number of a contact.
         *
         * @param request SendPhoneVerificationForMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPhoneVerificationForMessageContactResponse
         */
        public SendPhoneVerificationForMessageContactResponse SendPhoneVerificationForMessageContactWithOptions(SendPhoneVerificationForMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendPhoneVerificationForMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPhoneVerificationForMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sends verification information to the mobile phone number of a contact.
         *
         * @param request SendPhoneVerificationForMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPhoneVerificationForMessageContactResponse
         */
        public async Task<SendPhoneVerificationForMessageContactResponse> SendPhoneVerificationForMessageContactWithOptionsAsync(SendPhoneVerificationForMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendPhoneVerificationForMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPhoneVerificationForMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sends verification information to the mobile phone number of a contact.
         *
         * @param request SendPhoneVerificationForMessageContactRequest
         * @return SendPhoneVerificationForMessageContactResponse
         */
        public SendPhoneVerificationForMessageContactResponse SendPhoneVerificationForMessageContact(SendPhoneVerificationForMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendPhoneVerificationForMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Sends verification information to the mobile phone number of a contact.
         *
         * @param request SendPhoneVerificationForMessageContactRequest
         * @return SendPhoneVerificationForMessageContactResponse
         */
        public async Task<SendPhoneVerificationForMessageContactResponse> SendPhoneVerificationForMessageContactAsync(SendPhoneVerificationForMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendPhoneVerificationForMessageContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sends a verification code to the mobile phone number that you want to bind to a member of the resource account type in a resource directory for security purposes.
         *
         * @description To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request SendVerificationCodeForBindSecureMobilePhoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendVerificationCodeForBindSecureMobilePhoneResponse
         */
        public SendVerificationCodeForBindSecureMobilePhoneResponse SendVerificationCodeForBindSecureMobilePhoneWithOptions(SendVerificationCodeForBindSecureMobilePhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerificationCodeForBindSecureMobilePhone",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationCodeForBindSecureMobilePhoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sends a verification code to the mobile phone number that you want to bind to a member of the resource account type in a resource directory for security purposes.
         *
         * @description To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request SendVerificationCodeForBindSecureMobilePhoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendVerificationCodeForBindSecureMobilePhoneResponse
         */
        public async Task<SendVerificationCodeForBindSecureMobilePhoneResponse> SendVerificationCodeForBindSecureMobilePhoneWithOptionsAsync(SendVerificationCodeForBindSecureMobilePhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerificationCodeForBindSecureMobilePhone",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationCodeForBindSecureMobilePhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sends a verification code to the mobile phone number that you want to bind to a member of the resource account type in a resource directory for security purposes.
         *
         * @description To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request SendVerificationCodeForBindSecureMobilePhoneRequest
         * @return SendVerificationCodeForBindSecureMobilePhoneResponse
         */
        public SendVerificationCodeForBindSecureMobilePhoneResponse SendVerificationCodeForBindSecureMobilePhone(SendVerificationCodeForBindSecureMobilePhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendVerificationCodeForBindSecureMobilePhoneWithOptions(request, runtime);
        }

        /**
         * @summary Sends a verification code to the mobile phone number that you want to bind to a member of the resource account type in a resource directory for security purposes.
         *
         * @description To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this API operation.
         *
         * @param request SendVerificationCodeForBindSecureMobilePhoneRequest
         * @return SendVerificationCodeForBindSecureMobilePhoneResponse
         */
        public async Task<SendVerificationCodeForBindSecureMobilePhoneResponse> SendVerificationCodeForBindSecureMobilePhoneAsync(SendVerificationCodeForBindSecureMobilePhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendVerificationCodeForBindSecureMobilePhoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sends a verification code to the mobile phone number bound to a newly created account when you use the account to enable a resource directory.
         *
         * @description Each Alibaba Cloud account can be used to send a maximum of 100 verification codes per day.
         *
         * @param request SendVerificationCodeForEnableRDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendVerificationCodeForEnableRDResponse
         */
        public SendVerificationCodeForEnableRDResponse SendVerificationCodeForEnableRDWithOptions(SendVerificationCodeForEnableRDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerificationCodeForEnableRD",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationCodeForEnableRDResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sends a verification code to the mobile phone number bound to a newly created account when you use the account to enable a resource directory.
         *
         * @description Each Alibaba Cloud account can be used to send a maximum of 100 verification codes per day.
         *
         * @param request SendVerificationCodeForEnableRDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendVerificationCodeForEnableRDResponse
         */
        public async Task<SendVerificationCodeForEnableRDResponse> SendVerificationCodeForEnableRDWithOptionsAsync(SendVerificationCodeForEnableRDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureMobilePhone))
            {
                query["SecureMobilePhone"] = request.SecureMobilePhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerificationCodeForEnableRD",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationCodeForEnableRDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sends a verification code to the mobile phone number bound to a newly created account when you use the account to enable a resource directory.
         *
         * @description Each Alibaba Cloud account can be used to send a maximum of 100 verification codes per day.
         *
         * @param request SendVerificationCodeForEnableRDRequest
         * @return SendVerificationCodeForEnableRDResponse
         */
        public SendVerificationCodeForEnableRDResponse SendVerificationCodeForEnableRD(SendVerificationCodeForEnableRDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendVerificationCodeForEnableRDWithOptions(request, runtime);
        }

        /**
         * @summary Sends a verification code to the mobile phone number bound to a newly created account when you use the account to enable a resource directory.
         *
         * @description Each Alibaba Cloud account can be used to send a maximum of 100 verification codes per day.
         *
         * @param request SendVerificationCodeForEnableRDRequest
         * @return SendVerificationCodeForEnableRDResponse
         */
        public async Task<SendVerificationCodeForEnableRDResponse> SendVerificationCodeForEnableRDAsync(SendVerificationCodeForEnableRDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendVerificationCodeForEnableRDWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the member deletion feature.
         *
         * @description Members of the resource account type can be deleted only after the member deletion feature is enabled.
         *
         * @param request SetMemberDeletionPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetMemberDeletionPermissionResponse
         */
        public SetMemberDeletionPermissionResponse SetMemberDeletionPermissionWithOptions(SetMemberDeletionPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMemberDeletionPermission",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMemberDeletionPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the member deletion feature.
         *
         * @description Members of the resource account type can be deleted only after the member deletion feature is enabled.
         *
         * @param request SetMemberDeletionPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetMemberDeletionPermissionResponse
         */
        public async Task<SetMemberDeletionPermissionResponse> SetMemberDeletionPermissionWithOptionsAsync(SetMemberDeletionPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMemberDeletionPermission",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMemberDeletionPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the member deletion feature.
         *
         * @description Members of the resource account type can be deleted only after the member deletion feature is enabled.
         *
         * @param request SetMemberDeletionPermissionRequest
         * @return SetMemberDeletionPermissionResponse
         */
        public SetMemberDeletionPermissionResponse SetMemberDeletionPermission(SetMemberDeletionPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMemberDeletionPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the member deletion feature.
         *
         * @description Members of the resource account type can be deleted only after the member deletion feature is enabled.
         *
         * @param request SetMemberDeletionPermissionRequest
         * @return SetMemberDeletionPermissionResponse
         */
        public async Task<SetMemberDeletionPermissionResponse> SetMemberDeletionPermissionAsync(SetMemberDeletionPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMemberDeletionPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds tags to the members in a resource directory.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds tags to the members in a resource directory.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds tags to the members in a resource directory.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Adds tags to the members in a resource directory.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from the members in a resource directory.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from the members in a resource directory.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from the members in a resource directory.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from the members in a resource directory.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the display name of a member, or switches the type of a member.
         *
         * @description *   To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this operation.
         * *   Before you switch the type of a member from resource account to cloud account, make sure that specific conditions are met. For more information about the conditions, see [Switch a resource account to a cloud account](https://help.aliyun.com/document_detail/111233.html).
         * *   Before you switch the type of a member from cloud account to resource account, make sure that specific conditions are met. For more information about the conditions, see [Switch a cloud account to a resource account](https://help.aliyun.com/document_detail/209980.html).
         *
         * @param request UpdateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccountResponse
         */
        public UpdateAccountResponse UpdateAccountWithOptions(UpdateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccountType))
            {
                query["NewAccountType"] = request.NewAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the display name of a member, or switches the type of a member.
         *
         * @description *   To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this operation.
         * *   Before you switch the type of a member from resource account to cloud account, make sure that specific conditions are met. For more information about the conditions, see [Switch a resource account to a cloud account](https://help.aliyun.com/document_detail/111233.html).
         * *   Before you switch the type of a member from cloud account to resource account, make sure that specific conditions are met. For more information about the conditions, see [Switch a cloud account to a resource account](https://help.aliyun.com/document_detail/209980.html).
         *
         * @param request UpdateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccountResponse
         */
        public async Task<UpdateAccountResponse> UpdateAccountWithOptionsAsync(UpdateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccountType))
            {
                query["NewAccountType"] = request.NewAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccount",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the display name of a member, or switches the type of a member.
         *
         * @description *   To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this operation.
         * *   Before you switch the type of a member from resource account to cloud account, make sure that specific conditions are met. For more information about the conditions, see [Switch a resource account to a cloud account](https://help.aliyun.com/document_detail/111233.html).
         * *   Before you switch the type of a member from cloud account to resource account, make sure that specific conditions are met. For more information about the conditions, see [Switch a cloud account to a resource account](https://help.aliyun.com/document_detail/209980.html).
         *
         * @param request UpdateAccountRequest
         * @return UpdateAccountResponse
         */
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountWithOptions(request, runtime);
        }

        /**
         * @summary Changes the display name of a member, or switches the type of a member.
         *
         * @description *   To ensure that the system can record the operators of management operations, you must use a RAM user or RAM role to which the AliyunResourceDirectoryFullAccess policy is attached within the management account of your resource directory to call this operation.
         * *   Before you switch the type of a member from resource account to cloud account, make sure that specific conditions are met. For more information about the conditions, see [Switch a resource account to a cloud account](https://help.aliyun.com/document_detail/111233.html).
         * *   Before you switch the type of a member from cloud account to resource account, make sure that specific conditions are met. For more information about the conditions, see [Switch a cloud account to a resource account](https://help.aliyun.com/document_detail/209980.html).
         *
         * @param request UpdateAccountRequest
         * @return UpdateAccountResponse
         */
        public async Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a custom access control policy.
         *
         * @param request UpdateControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateControlPolicyResponse
         */
        public UpdateControlPolicyResponse UpdateControlPolicyWithOptions(UpdateControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPolicyDocument))
            {
                query["NewPolicyDocument"] = request.NewPolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPolicyName))
            {
                query["NewPolicyName"] = request.NewPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a custom access control policy.
         *
         * @param request UpdateControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateControlPolicyResponse
         */
        public async Task<UpdateControlPolicyResponse> UpdateControlPolicyWithOptionsAsync(UpdateControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPolicyDocument))
            {
                query["NewPolicyDocument"] = request.NewPolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPolicyName))
            {
                query["NewPolicyName"] = request.NewPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPolicy",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a custom access control policy.
         *
         * @param request UpdateControlPolicyRequest
         * @return UpdateControlPolicyResponse
         */
        public UpdateControlPolicyResponse UpdateControlPolicy(UpdateControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Updates a custom access control policy.
         *
         * @param request UpdateControlPolicyRequest
         * @return UpdateControlPolicyResponse
         */
        public async Task<UpdateControlPolicyResponse> UpdateControlPolicyAsync(UpdateControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the name of a folder.
         *
         * @param request UpdateFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFolderResponse
         */
        public UpdateFolderResponse UpdateFolderWithOptions(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFolderName))
            {
                query["NewFolderName"] = request.NewFolderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the name of a folder.
         *
         * @param request UpdateFolderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFolderResponse
         */
        public async Task<UpdateFolderResponse> UpdateFolderWithOptionsAsync(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFolderName))
            {
                query["NewFolderName"] = request.NewFolderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the name of a folder.
         *
         * @param request UpdateFolderRequest
         * @return UpdateFolderResponse
         */
        public UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFolderWithOptions(request, runtime);
        }

        /**
         * @summary Changes the name of a folder.
         *
         * @param request UpdateFolderRequest
         * @return UpdateFolderResponse
         */
        public async Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFolderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a contact.
         *
         * @param request UpdateMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMessageContactResponse
         */
        public UpdateMessageContactResponse UpdateMessageContactWithOptions(UpdateMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypes))
            {
                query["MessageTypes"] = request.MessageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a contact.
         *
         * @param request UpdateMessageContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMessageContactResponse
         */
        public async Task<UpdateMessageContactResponse> UpdateMessageContactWithOptionsAsync(UpdateMessageContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailAddress))
            {
                query["EmailAddress"] = request.EmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypes))
            {
                query["MessageTypes"] = request.MessageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMessageContact",
                Version = "2022-04-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a contact.
         *
         * @param request UpdateMessageContactRequest
         * @return UpdateMessageContactResponse
         */
        public UpdateMessageContactResponse UpdateMessageContact(UpdateMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMessageContactWithOptions(request, runtime);
        }

        /**
         * @summary Updates a contact.
         *
         * @param request UpdateMessageContactRequest
         * @return UpdateMessageContactResponse
         */
        public async Task<UpdateMessageContactResponse> UpdateMessageContactAsync(UpdateMessageContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMessageContactWithOptionsAsync(request, runtime);
        }

    }
}
